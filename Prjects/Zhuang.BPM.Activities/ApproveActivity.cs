using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace Zhuang.BPM.Activities
{

    public class ApproveActivity : NativeActivity<string>
    {
        public ApproveActivity() 
        {
            DisplayName = "审批结点";
        }


        protected override bool CanInduceIdle
        {
            get{ return true; }
        }

        protected override void Execute(NativeActivityContext context)
        {

            context.CreateBookmark(DisplayName, new BookmarkCallback(OnBookmarkCallback));

        }

        private void OnBookmarkCallback(NativeActivityContext context, Bookmark bookmark, object value)
        {
            this.Result.Set(context, "pass");

        }
    }
}
