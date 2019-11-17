#define NAVMESHCOMPONENTS_SHOW_NAVMESHDATA_REF

using System.Linq;
using UnityEditor.IMGUI.Controls;
using UnityEditorInternal;
using UnityEngine.AI;
using UnityEngine;

namespace UnityEditor.AI
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(NavMeshSurface))]
    internal class NavMeshSurfaceEditor : Editor
    {
        private SerializedProperty _mAgentTypeId;
        private SerializedProperty _mBuildHeightMesh;
        private SerializedProperty _mCenter;
        private SerializedProperty _mCollectObjects;
        private SerializedProperty _mDefaultArea;
        private SerializedProperty _mLayerMask;
        private SerializedProperty _mOverrideTileSize;
        private SerializedProperty _mOverrideVoxelSize;
        private SerializedProperty _mSize;
        private SerializedProperty _mTileSize;
        private SerializedProperty _mUseGeometry;
        private SerializedProperty _mVoxelSize;

#if NAVMESHCOMPONENTS_SHOW_NAVMESHDATA_REF
        private SerializedProperty _mNavMeshData;
#endif
        private class Styles
        {
            public readonly GUIContent MLayerMask = new GUIContent("Include Layers");

            public readonly GUIContent MShowInputGeom = new GUIContent("Show Input Geom");
            public readonly GUIContent MShowVoxels = new GUIContent("Show Voxels");
            public readonly GUIContent MShowRegions = new GUIContent("Show Regions");
            public readonly GUIContent MShowRawContours = new GUIContent("Show Raw Contours");
            public readonly GUIContent MShowContours = new GUIContent("Show Contours");
            public readonly GUIContent MShowPolyMesh = new GUIContent("Show Poly Mesh");
            public readonly GUIContent MShowPolyMeshDetail = new GUIContent("Show Poly Mesh Detail");
        }

        private static Styles _sStyles;

        private static bool _sShowDebugOptions;

        private static Color _sHandleColor = new Color(127f, 214f, 244f, 100f) / 255;
        private static Color _sHandleColorSelected = new Color(127f, 214f, 244f, 210f) / 255;
        private static Color _sHandleColorDisabled = new Color(127f * 0.75f, 214f * 0.75f, 244f * 0.75f, 100f) / 255;

        private BoxBoundsHandle _mBoundsHandle = new BoxBoundsHandle();

        private bool EditingCollider
        {
            get { return EditMode.editMode == EditMode.SceneViewEditMode.Collider && EditMode.IsOwner(this); }
        }

        private void OnEnable()
        {
            _mAgentTypeId = serializedObject.FindProperty("m_AgentTypeID");
            _mBuildHeightMesh = serializedObject.FindProperty("m_BuildHeightMesh");
            _mCenter = serializedObject.FindProperty("m_Center");
            _mCollectObjects = serializedObject.FindProperty("m_CollectObjects");
            _mDefaultArea = serializedObject.FindProperty("m_DefaultArea");
            _mLayerMask = serializedObject.FindProperty("m_LayerMask");
            _mOverrideTileSize = serializedObject.FindProperty("m_OverrideTileSize");
            _mOverrideVoxelSize = serializedObject.FindProperty("m_OverrideVoxelSize");
            _mSize = serializedObject.FindProperty("m_Size");
            _mTileSize = serializedObject.FindProperty("m_TileSize");
            _mUseGeometry = serializedObject.FindProperty("m_UseGeometry");
            _mVoxelSize = serializedObject.FindProperty("m_VoxelSize");

#if NAVMESHCOMPONENTS_SHOW_NAVMESHDATA_REF
            _mNavMeshData = serializedObject.FindProperty("m_NavMeshData");
#endif
            NavMeshVisualizationSettings.showNavigation++;
        }

        private void OnDisable()
        {
            NavMeshVisualizationSettings.showNavigation--;
        }

        private Bounds GetBounds()
        {
            var navSurface = (NavMeshSurface)target;
            return new Bounds(navSurface.transform.position, navSurface.Size);
        }

        public override void OnInspectorGUI()
        {
            if (_sStyles == null)
                _sStyles = new Styles();

            serializedObject.Update();

            var bs = NavMesh.GetSettingsByID(_mAgentTypeId.intValue);

            if (bs.agentTypeID != -1)
            {
                // Draw image
                const float diagramHeight = 80.0f;
                Rect agentDiagramRect = EditorGUILayout.GetControlRect(false, diagramHeight);
                NavMeshEditorHelpers.DrawAgentDiagram(agentDiagramRect, bs.agentRadius, bs.agentHeight, bs.agentClimb, bs.agentSlope);
            }
            NavMeshComponentsGuiUtility.AgentTypePopup("Agent Type", _mAgentTypeId);

            EditorGUILayout.Space();

            EditorGUILayout.PropertyField(_mCollectObjects);
            if ((CollectObjects)_mCollectObjects.enumValueIndex == CollectObjects.Volume)
            {
                EditorGUI.indentLevel++;

                EditMode.DoEditModeInspectorModeButton(EditMode.SceneViewEditMode.Collider, "Edit Volume",
                    EditorGUIUtility.IconContent("EditCollider"), GetBounds, this);
                EditorGUILayout.PropertyField(_mSize);
                EditorGUILayout.PropertyField(_mCenter);

                EditorGUI.indentLevel--;
            }
            else
            {
                if (EditingCollider)
                    EditMode.QuitEditMode();
            }

            EditorGUILayout.PropertyField(_mLayerMask, _sStyles.MLayerMask);
            EditorGUILayout.PropertyField(_mUseGeometry);

            EditorGUILayout.Space();

            _mOverrideVoxelSize.isExpanded = EditorGUILayout.Foldout(_mOverrideVoxelSize.isExpanded, "Advanced");
            if (_mOverrideVoxelSize.isExpanded)
            {
                EditorGUI.indentLevel++;

                NavMeshComponentsGuiUtility.AreaPopup("Default Area", _mDefaultArea);

                // Override voxel size.
                EditorGUILayout.PropertyField(_mOverrideVoxelSize);

                using (new EditorGUI.DisabledScope(!_mOverrideVoxelSize.boolValue || _mOverrideVoxelSize.hasMultipleDifferentValues))
                {
                    EditorGUI.indentLevel++;

                    EditorGUILayout.PropertyField(_mVoxelSize);

                    if (!_mOverrideVoxelSize.hasMultipleDifferentValues)
                    {
                        if (!_mAgentTypeId.hasMultipleDifferentValues)
                        {
                            float voxelsPerRadius = _mVoxelSize.floatValue > 0.0f ? bs.agentRadius / _mVoxelSize.floatValue : 0.0f;
                            EditorGUILayout.LabelField(" ", voxelsPerRadius.ToString("0.00") + " voxels per agent radius", EditorStyles.miniLabel);
                        }
                        if (_mOverrideVoxelSize.boolValue)
                            EditorGUILayout.HelpBox("Voxel size controls how accurately the navigation mesh is generated from the level geometry. A good voxel size is 2-4 voxels per agent radius. Making voxel size smaller will increase build time.", MessageType.None);
                    }
                    EditorGUI.indentLevel--;
                }

                // Override tile size
                EditorGUILayout.PropertyField(_mOverrideTileSize);

                using (new EditorGUI.DisabledScope(!_mOverrideTileSize.boolValue || _mOverrideTileSize.hasMultipleDifferentValues))
                {
                    EditorGUI.indentLevel++;

                    EditorGUILayout.PropertyField(_mTileSize);

                    if (!_mTileSize.hasMultipleDifferentValues && !_mVoxelSize.hasMultipleDifferentValues)
                    {
                        float tileWorldSize = _mTileSize.intValue * _mVoxelSize.floatValue;
                        EditorGUILayout.LabelField(" ", tileWorldSize.ToString("0.00") + " world units", EditorStyles.miniLabel);
                    }

                    if (!_mOverrideTileSize.hasMultipleDifferentValues)
                    {
                        if (_mOverrideTileSize.boolValue)
                            EditorGUILayout.HelpBox("Tile size controls the how local the changes to the world are (rebuild or carve). Small tile size allows more local changes, while potentially generating more data overall.", MessageType.None);
                    }
                    EditorGUI.indentLevel--;
                }


                // Height mesh
                using (new EditorGUI.DisabledScope(true))
                {
                    EditorGUILayout.PropertyField(_mBuildHeightMesh);
                }

                EditorGUILayout.Space();
                EditorGUI.indentLevel--;
            }

            EditorGUILayout.Space();

            serializedObject.ApplyModifiedProperties();

            var hadError = false;
            var multipleTargets = targets.Length > 1;
            foreach (NavMeshSurface navSurface in targets)
            {
                var settings = navSurface.GetBuildSettings();
                // Calculating bounds is potentially expensive when unbounded - so here we just use the center/size.
                // It means the validation is not checking vertical voxel limit correctly when the surface is set to something else than "in volume".
                var bounds = new Bounds(Vector3.zero, Vector3.zero);
                if (navSurface.CollectObjects == CollectObjects.Volume)
                {
                    bounds = new Bounds(navSurface.Center, navSurface.Size);
                }

                var errors = settings.ValidationReport(bounds);
                if (errors.Length > 0)
                {
                    if (multipleTargets)
                        EditorGUILayout.LabelField(navSurface.name);
                    foreach (var err in errors)
                    {
                        EditorGUILayout.HelpBox(err, MessageType.Warning);
                    }
                    GUILayout.BeginHorizontal();
                    GUILayout.Space(EditorGUIUtility.labelWidth);
                    if (GUILayout.Button("Open Agent Settings...", EditorStyles.miniButton))
                        NavMeshEditorHelpers.OpenAgentSettings(navSurface.AgentTypeId);
                    GUILayout.EndHorizontal();
                    hadError = true;
                }
            }

            if (hadError)
                EditorGUILayout.Space();

#if NAVMESHCOMPONENTS_SHOW_NAVMESHDATA_REF
            var nmdRect = EditorGUILayout.GetControlRect(true, EditorGUIUtility.singleLineHeight);

            EditorGUI.BeginProperty(nmdRect, GUIContent.none, _mNavMeshData);
            var rectLabel = EditorGUI.PrefixLabel(nmdRect, GUIUtility.GetControlID(FocusType.Passive), new GUIContent(_mNavMeshData.displayName));
            EditorGUI.EndProperty();

            using (new EditorGUI.DisabledScope(true))
            {
                EditorGUI.BeginProperty(nmdRect, GUIContent.none, _mNavMeshData);
                EditorGUI.ObjectField(rectLabel, _mNavMeshData, GUIContent.none);
                EditorGUI.EndProperty();
            }
#endif
            using (new EditorGUI.DisabledScope(Application.isPlaying || _mAgentTypeId.intValue == -1))
            {
                GUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUIUtility.labelWidth);
                if (GUILayout.Button("Clear"))
                {
                    NavMeshAssetManager.instance.ClearSurfaces(targets);
                    SceneView.RepaintAll();
                }

                if (GUILayout.Button("Bake"))
                {
                    NavMeshAssetManager.instance.StartBakingSurfaces(targets);
                }

                GUILayout.EndHorizontal();
            }

            // Show progress for the selected targets
            var bakeOperations = NavMeshAssetManager.instance.GetBakeOperations();
            for (int i = bakeOperations.Count - 1; i >= 0; --i)
            {
                if (!targets.Contains(bakeOperations[i].Surface))
                    continue;

                var oper = bakeOperations[i].BakeOperation;
                if (oper == null)
                    continue;

                var p = oper.progress;
                if (oper.isDone)
                {
                    SceneView.RepaintAll();
                    continue;
                }

                GUILayout.BeginHorizontal();

                if (GUILayout.Button("Cancel", EditorStyles.miniButton))
                {
                    var bakeData = bakeOperations[i].BakeData;
                    UnityEngine.AI.NavMeshBuilder.Cancel(bakeData);
                    bakeOperations.RemoveAt(i);
                }

                EditorGUI.ProgressBar(EditorGUILayout.GetControlRect(), p, "Baking: " + (int)(100 * p) + "%");
                if (p <= 1)
                    Repaint();

                GUILayout.EndHorizontal();
            }
        }

        [DrawGizmo(GizmoType.Selected | GizmoType.Active | GizmoType.Pickable)]
        private static void RenderBoxGizmoSelected(NavMeshSurface navSurface, GizmoType gizmoType)
        {
            RenderBoxGizmo(navSurface, gizmoType, true);
        }

        [DrawGizmo(GizmoType.NotInSelectionHierarchy | GizmoType.Pickable)]
        private static void RenderBoxGizmoNotSelected(NavMeshSurface navSurface, GizmoType gizmoType)
        {
            if (NavMeshVisualizationSettings.showNavigation > 0)
                RenderBoxGizmo(navSurface, gizmoType, false);
            else
                Gizmos.DrawIcon(navSurface.transform.position, "NavMeshSurface Icon", true);
        }

        private static void RenderBoxGizmo(NavMeshSurface navSurface, GizmoType gizmoType, bool selected)
        {
            var color = selected ? _sHandleColorSelected : _sHandleColor;
            if (!navSurface.enabled)
                color = _sHandleColorDisabled;

            var oldColor = Gizmos.color;
            var oldMatrix = Gizmos.matrix;

            // Use the unscaled matrix for the NavMeshSurface
            var localToWorld = Matrix4x4.TRS(navSurface.transform.position, navSurface.transform.rotation, Vector3.one);
            Gizmos.matrix = localToWorld;

            if (navSurface.CollectObjects == CollectObjects.Volume)
            {
                Gizmos.color = color;
                Gizmos.DrawWireCube(navSurface.Center, navSurface.Size);

                if (selected && navSurface.enabled)
                {
                    var colorTrans = new Color(color.r * 0.75f, color.g * 0.75f, color.b * 0.75f, color.a * 0.15f);
                    Gizmos.color = colorTrans;
                    Gizmos.DrawCube(navSurface.Center, navSurface.Size);
                }
            }
            else
            {
                if (navSurface.NavMeshData != null)
                {
                    var bounds = navSurface.NavMeshData.sourceBounds;
                    Gizmos.color = Color.grey;
                    Gizmos.DrawWireCube(bounds.center, bounds.size);
                }
            }

            Gizmos.matrix = oldMatrix;
            Gizmos.color = oldColor;

            Gizmos.DrawIcon(navSurface.transform.position, "NavMeshSurface Icon", true);
        }

        private void OnSceneGUI()
        {
            if (!EditingCollider)
                return;

            var navSurface = (NavMeshSurface)target;
            var color = navSurface.enabled ? _sHandleColor : _sHandleColorDisabled;
            var localToWorld = Matrix4x4.TRS(navSurface.transform.position, navSurface.transform.rotation, Vector3.one);
            using (new Handles.DrawingScope(color, localToWorld))
            {
                _mBoundsHandle.center = navSurface.Center;
                _mBoundsHandle.size = navSurface.Size;

                EditorGUI.BeginChangeCheck();
                _mBoundsHandle.DrawHandle();
                if (EditorGUI.EndChangeCheck())
                {
                    Undo.RecordObject(navSurface, "Modified NavMesh Surface");
                    Vector3 center = _mBoundsHandle.center;
                    Vector3 size = _mBoundsHandle.size;
                    navSurface.Center = center;
                    navSurface.Size = size;
                    EditorUtility.SetDirty(target);
                }
            }
        }

        [MenuItem("GameObject/AI/NavMesh Surface", false, 2000)]
        public static void CreateNavMeshSurface(MenuCommand menuCommand)
        {
            var parent = menuCommand.context as GameObject;
            var go = NavMeshComponentsGuiUtility.CreateAndSelectGameObject("NavMesh Surface", parent);
            go.AddComponent<NavMeshSurface>();
            var view = SceneView.lastActiveSceneView;
            if (view != null)
                view.MoveToView(go.transform);
        }
    }
}
