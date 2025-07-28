using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagement
{
    class ResizeControls
    {
        private Dictionary<string, SizeRatio> RatioTable = new Dictionary<string, SizeRatio>();

        private float WindowHeight;
        private float WindowWidth;
        private float HeightRatio;
        private float WidthRatio;
        private Control _Container;

        public Control Container
        {
            get => _Container;
            set
            {
                _Container = value;
                FullRatioTable();
            }
        }

        private struct SizeRatio
        {
            public float TopRatio;
            public float LeftRatio;
            public float HeightRatio;
            public float WidthRatio;
        }

        private void FullRatioTable()
        {
            if (_Container == null) return;

            WindowHeight = _Container.Height;
            WindowWidth = _Container.Width;
            RatioTable.Clear();
            AddChildrenToTable(_Container);
        }

        private void AddChildrenToTable(Control childContainer)
        {
            foreach (Control C in childContainer.Controls)
            {
                var R = new SizeRatio
                {
                    TopRatio = C.Top / WindowHeight,
                    LeftRatio = C.Left / WindowWidth,
                    HeightRatio = C.Height / WindowHeight,
                    WidthRatio = C.Width / WindowWidth
                };

                RatioTable[C.Name] = R;

                if (C.HasChildren)
                {
                    AddChildrenToTable(C);
                }
            }
        }

        public void ResizeControl()
        {
            if (_Container == null || RatioTable.Count == 0) return;

            HeightRatio = _Container.Height / WindowHeight;
            WidthRatio = _Container.Width / WindowWidth;

            WindowHeight = _Container.Height;
            WindowWidth = _Container.Width;

            ResizeChildren(_Container);
        }

        private void ResizeChildren(Control childContainer)
        {
            foreach (Control C in childContainer.Controls)
            {
                if (RatioTable.TryGetValue(C.Name, out var R))
                {
                    C.Top = (int)(WindowHeight * R.TopRatio);
                    C.Left = (int)(WindowWidth * R.LeftRatio);
                    C.Height = (int)(WindowHeight * R.HeightRatio);
                    C.Width = (int)(WindowWidth * R.WidthRatio);
                }

                if (C.HasChildren)
                {
                    ResizeChildren(C);
                }

                if (C is ListBox listBox)
                {
                    listBox.IntegralHeight = false;
                }

                ResizeControlFont(C);
            }
        }

        private void ResizeControlFont(Control ctrl)
        {
            if (ctrl.Font == null) return;

            // تحقق من أن نسب العرض والارتفاع ليست صفراً
            if (WidthRatio <= 0 || HeightRatio <= 0) return;

            float newSize = ctrl.Font.Size * (float)Math.Sqrt(WidthRatio * HeightRatio);

            // تأكد من أن الحجم الجديد أكبر من الصفر وأقل من القيم العظمى المسموح بها
            if (newSize > 0 && newSize <= float.MaxValue)
            {
                ctrl.Font = new Font(ctrl.Font.FontFamily, newSize, ctrl.Font.Style);
            }
        }


    }
}
