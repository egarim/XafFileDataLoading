using DevExpress.ExpressApp;
using DevExpress.ExpressApp.FileAttachments.Win;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XafFileDataLoading.Module.BusinessObjects;

namespace XafFileDataLoading.Module.Win.Controllers
{
    public class MyViewController :ObjectViewController<DetailView, DomainObject1>
    {
        public MyViewController() : base()
        {
            // Target required Views (use the TargetXXX properties) and create their Actions.
            
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            var FileDataEditor=this.View.FindItem(nameof(DomainObject1.File));
            var FileDataEditorControl=FileDataEditor.Control as FileDataEdit;
            FileDataEditorControl.Modified += FileDataEditorControl_Modified;
            // Access and customize the target View control.
        }

        private void FileDataEditorControl_Modified(object sender, EventArgs e)
        {
            var CurrentFileDataEdit=  sender as FileDataEdit;
            if(CurrentFileDataEdit.FileData.Size>0)
            {
                MemoryStream stream = new MemoryStream();
                CurrentFileDataEdit.FileData.SaveToStream(stream);
                var ContentLengt = stream.Length;
            }
        }
    }
}
