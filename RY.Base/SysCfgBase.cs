using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RY.Base
{

    [Serializable]
    public class SysCfgBase:ConfigBase
    {

        [BrowsableAttribute(false)]
        public string OperatorPSW
        { get; set; } = DESEncrypt.Encrypt("testme");

        [BrowsableAttribute(false)]
        public string EngineerPSW
        { get; set; } = DESEncrypt.Encrypt("RYRYRY");

        [BrowsableAttribute(false)]
        public string AdminPSW
        { get; set; } = DESEncrypt.Encrypt("RYAdmin");


        [Category("设置")]
        [Description("软件界面的名称")]
        [DisplayName("名称")]
        public string FrmCaption
        {
            get; set;
        } = "睿颖智能";
    }
}
