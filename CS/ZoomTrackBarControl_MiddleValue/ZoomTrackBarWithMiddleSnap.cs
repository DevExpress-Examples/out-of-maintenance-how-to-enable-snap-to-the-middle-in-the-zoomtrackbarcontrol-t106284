using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomTrackBarControl_MiddleValue {

    [UserRepositoryItem("Register")]
    public class CustomRepositoryItem : RepositoryItemZoomTrackBar {
        static CustomRepositoryItem() {
            Register();
        }

        public CustomRepositoryItem() { }

        internal const string EditorName = "CustomZoomTrackBar";

        public static void Register() {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(CustomZoomTrackBar),
                typeof(CustomRepositoryItem), typeof(CustomViewInfo),
                new ZoomTrackBarPainter(), true, null, typeof(DevExpress.Accessibility.ButtonEditAccessible)));
        }

        public override string EditorTypeName {
            get { return EditorName; }
        }

        private bool _SnapToMiddleValue;
        public bool SnapToMiddleValue {
            get { return _SnapToMiddleValue; }
            set { _SnapToMiddleValue = value; }
        }

        private int _MiddleDistance;
        public int MiddleDistance {
            get {
                if (_MiddleDistance > 100 || _MiddleDistance <= 0)
                    _MiddleDistance = 10;
                return _MiddleDistance;
            }
            set {
                _MiddleDistance = value;
            }
        }

        public override void Assign(RepositoryItem item) {
            base.Assign(item);
            BeginUpdate();
            try {
                base.Assign(item);
                CustomRepositoryItem source = item as CustomRepositoryItem;
                if (source == null) return;
                SnapToMiddleValue = source.SnapToMiddleValue;
                MiddleDistance = source.MiddleDistance;
            }
            finally {
                EndUpdate();
            }
        }
    }

    [ToolboxItem(true)]
    public class CustomZoomTrackBar : ZoomTrackBarControl {
        static CustomZoomTrackBar() {
            CustomRepositoryItem.Register();
        }

        public CustomZoomTrackBar() {
        }


        public override string EditorTypeName {
            get { return CustomRepositoryItem.EditorName; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new CustomRepositoryItem Properties {
            get { return base.Properties as CustomRepositoryItem; }
        }

    }

    public class CustomViewInfo : ZoomTrackBarViewInfo {
        public CustomViewInfo(RepositoryItem item)
            : base(item) {
        }

        public override int ValueFromPoint(Point p) {
            CustomRepositoryItem customItem = (CustomRepositoryItem)this.Item;
            int middle = (customItem.AllowUseMiddleValue) ? customItem.Middle : (customItem.Minimum + customItem.Maximum) / 2;
            int value = base.ValueFromPoint(p);
            int middleDistance = (customItem.Minimum + customItem.Maximum) / customItem.MiddleDistance;

            if (value >= middle - middleDistance && value <= middle + middleDistance)
                return middle;
            return value;
        }

    }

}
