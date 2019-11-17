using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.AI
{
    [ExecuteInEditMode]
    [DefaultExecutionOrder(-101)]
    [AddComponentMenu("Navigation/NavMeshLink", 33)]
    [HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
    public class NavMeshLink : MonoBehaviour
    {
        [FormerlySerializedAs("m_AgentTypeID")] [SerializeField] private int mAgentTypeId;
        public int AgentTypeId { get { return mAgentTypeId; } set { mAgentTypeId = value; UpdateLink(); } }

        [FormerlySerializedAs("m_StartPoint")] [SerializeField] private Vector3 mStartPoint = new Vector3(0.0f, 0.0f, -2.5f);
        public Vector3 StartPoint { get { return mStartPoint; } set { mStartPoint = value; UpdateLink(); } }

        [FormerlySerializedAs("m_EndPoint")] [SerializeField] private Vector3 mEndPoint = new Vector3(0.0f, 0.0f, 2.5f);
        public Vector3 EndPoint { get { return mEndPoint; } set { mEndPoint = value; UpdateLink(); } }

        [FormerlySerializedAs("m_Width")] [SerializeField] private float mWidth;
        public float Width { get { return mWidth; } set { mWidth = value; UpdateLink(); } }

        [FormerlySerializedAs("m_CostModifier")] [SerializeField] private int mCostModifier = -1;
        public int CostModifier { get { return mCostModifier; } set { mCostModifier = value; UpdateLink(); } }

        [FormerlySerializedAs("m_Bidirectional")] [SerializeField] private bool mBidirectional = true;
        public bool Bidirectional { get { return mBidirectional; } set { mBidirectional = value; UpdateLink(); } }

        [FormerlySerializedAs("m_AutoUpdatePosition")] [SerializeField] private bool mAutoUpdatePosition;
        public bool AutoUpdate { get { return mAutoUpdatePosition; } set { SetAutoUpdate(value); } }

        [FormerlySerializedAs("m_Area")] [SerializeField] private int mArea;
        public int Area { get { return mArea; } set { mArea = value; UpdateLink(); } }

        private NavMeshLinkInstance _mLinkInstance = new NavMeshLinkInstance();

        private Vector3 _mLastPosition = Vector3.zero;
        private Quaternion _mLastRotation = Quaternion.identity;

        private static readonly List<NavMeshLink> STracked = new List<NavMeshLink>();

        private void OnEnable()
        {
            AddLink();
            if (mAutoUpdatePosition && _mLinkInstance.valid)
                AddTracking(this);
        }

        private void OnDisable()
        {
            RemoveTracking(this);
            _mLinkInstance.Remove();
        }

        public void UpdateLink()
        {
            _mLinkInstance.Remove();
            AddLink();
        }

        private static void AddTracking(NavMeshLink link)
        {
#if UNITY_EDITOR
            if (STracked.Contains(link))
            {
                Debug.LogError("Link is already tracked: " + link);
                return;
            }
#endif

            if (STracked.Count == 0)
                NavMesh.onPreUpdate += UpdateTrackedInstances;

            STracked.Add(link);
        }

        private static void RemoveTracking(NavMeshLink link)
        {
            STracked.Remove(link);

            if (STracked.Count == 0)
                NavMesh.onPreUpdate -= UpdateTrackedInstances;
        }

        private void SetAutoUpdate(bool value)
        {
            if (mAutoUpdatePosition == value)
                return;
            mAutoUpdatePosition = value;
            if (value)
                AddTracking(this);
            else
                RemoveTracking(this);
        }

        private void AddLink()
        {
#if UNITY_EDITOR
            if (_mLinkInstance.valid)
            {
                Debug.LogError("Link is already added: " + this);
                return;
            }
#endif

            var link = new NavMeshLinkData();
            link.startPosition = mStartPoint;
            link.endPosition = mEndPoint;
            link.width = mWidth;
            link.costModifier = mCostModifier;
            link.bidirectional = mBidirectional;
            link.area = mArea;
            link.agentTypeID = mAgentTypeId;
            _mLinkInstance = NavMesh.AddLink(link, transform.position, transform.rotation);
            if (_mLinkInstance.valid)
                _mLinkInstance.owner = this;

            _mLastPosition = transform.position;
            _mLastRotation = transform.rotation;
        }

        private bool HasTransformChanged()
        {
            if (_mLastPosition != transform.position) return true;
            if (_mLastRotation != transform.rotation) return true;
            return false;
        }

        private void OnDidApplyAnimationProperties()
        {
            UpdateLink();
        }

        private static void UpdateTrackedInstances()
        {
            foreach (var instance in STracked)
            {
                if (instance.HasTransformChanged())
                    instance.UpdateLink();
            }
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            mWidth = Mathf.Max(0.0f, mWidth);

            if (!_mLinkInstance.valid)
                return;

            UpdateLink();

            if (!mAutoUpdatePosition)
            {
                RemoveTracking(this);
            }
            else if (!STracked.Contains(this))
            {
                AddTracking(this);
            }
        }
#endif
    }
}
