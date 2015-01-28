using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing.Design;

namespace FindInFiles {

    public partial class PaddedListView : ListView {

        [DllImport( "user32.dll" )]
        public static extern int SendMessage( IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam );

        private short itemPadding;

        /// <summary>
        /// Expose the "Padding" property to the VS designer.
        /// </summary>
        [Browsable(true),
        DefaultValue((short) 0),
        Category("Layout"),
        Description("List item padding"),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public short ItemPadding {
            get { return itemPadding; }
            set {
                itemPadding = value;
                this.Invalidate();
            }
        }

        public int MakeLong( short lowPart, short highPart ) {
            return (int) ( ( (ushort) lowPart ) | (uint) ( highPart << 16 ) );
        }

        public void ListViewItem_SetSpacing( ListView listView, short x, short y ) {
            const int LVM_FIRST = 0x1000;
            const int LVM_SETICONSPACING = LVM_FIRST + 53;
            SendMessage( listView.Handle, LVM_SETICONSPACING, IntPtr.Zero, (IntPtr) MakeLong( x, y ) );
        }

        protected override void OnLayout( LayoutEventArgs levent ) {
            base.OnLayout( levent );
            Debug.WriteLine( "Setting padding to " + itemPadding + " - " + this.itemPadding + " - " + ItemPadding + " - " + this.ItemPadding );
            ListViewItem_SetSpacing( this, this.itemPadding, this.itemPadding );
        }

    }

}
