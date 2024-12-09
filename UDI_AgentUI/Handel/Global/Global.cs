using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDI_AgentUI.Handel.Global
{
    internal class Global : IGlobal
    {
        public string getDeviceBrnad(string deviceId)
        {
            string fullName = deviceId switch
            {
                "DAS01" =>"TERAKO",
                "PCRS01"=> "ISHIDA",
                "LCU01"=> "TERAKO",
                "WAS01"=>"PX",
                _=>""
            };

            return fullName;
        }

        public string oderTypeName(string num)
        {
            string typeName = num switch
            {
                "0" => "設備啟動程序",
                "1" => "實績刪除",
                "2" => "指示刪除",
                "3" => "取得實績",
                "4" => "取得實績(完整)",
                "5"=> "生產指示主檔",
                "8" => "商品主檔",
                "9" => "門市主檔",
                "10" => "產地主檔",
                "11" => "原材料主檔",
                "12" => "註釋主檔",
                "13" => "保存方法主檔",
                "14" => "作業者主檔",
                "15" => "托盤主檔",
                "16" => "添加物主檔",
                "17" => "廣告文主檔",
                "18" => "班次主檔",
                _ => "未知程序"
            };
            return typeName;
        }
    }
}
