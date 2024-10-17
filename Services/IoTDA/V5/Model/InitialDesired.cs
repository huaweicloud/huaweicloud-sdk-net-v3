using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 设备初始配置数据结构体。
    /// </summary>
    public class InitialDesired 
    {

        /// <summary>
        /// **参数说明**：设备的服务ID，在设备关联的产品模型中定义。 **取值范围**：长度不超过32，只允许中文、字母、数字、以及_?&#39;#().,&amp;%@!-等字符的组合。
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }

        /// <summary>
        /// **参数说明**：设备初始配置属性数据，Json格式，里面是一个个键值对，每个键都是产品模型中属性的参数名(property_name)，目前如样例所示只支持一层结构；这里设置的属性值与产品中对应属性的默认值比对，如果不同，则将以该字段中设置的属性值为准写入到设备影子中；如果想要删除整个desired可以填写空object(例如\&quot;desired\&quot;:{})，如果想要删除某一个属性期望值可以将属性置位null(例如{\&quot;temperature\&quot;:null})
        /// </summary>
        [JsonProperty("desired", NullValueHandling = NullValueHandling.Ignore)]
        public Object Desired { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitialDesired {\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  desired: ").Append(Desired).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InitialDesired);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InitialDesired input)
        {
            if (input == null) return false;
            if (this.ServiceId != input.ServiceId || (this.ServiceId != null && !this.ServiceId.Equals(input.ServiceId))) return false;
            if (this.Desired != input.Desired || (this.Desired != null && !this.Desired.Equals(input.Desired))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.ServiceId != null) hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.Desired != null) hashCode = hashCode * 59 + this.Desired.GetHashCode();
                return hashCode;
            }
        }
    }
}
