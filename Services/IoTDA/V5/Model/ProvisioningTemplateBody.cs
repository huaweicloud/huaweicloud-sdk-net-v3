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
    /// 预调配模板详细内容。
    /// </summary>
    public class ProvisioningTemplateBody 
    {

        /// <summary>
        /// **参数说明**：预调配模板参数， ，配置格式为{\&quot;parameter\&quot;:{\&quot;type\&quot;:\&quot;String\&quot;}} ，其中parameter目前支持从预调配设备的证书的使用者字段提取内容，证书必须包含模板中定义的所有参数值，华为云IoT平台定义了可在预调配模板中声明和引用的如下参数: - iotda::certificate::country (国家/地区,C ) - iotda::certificate::organization (组织,O) - iotda::certificate::organizational_unit (组织单位,OU) - iotda::certificate::distinguished_name_qualifier (可辨别名称限定符,dnQualifier) - iotda::certificate::state_name (省市,ST) - iotda::certificate::common_name (公用名,CN) - iotda::certificate::serial_number (序列号,serialNumber)  type描述parameter的类型，目前仅支持string。  配置样例：  &#39;{\&quot;iotda::certificate::country\&quot;:{\&quot;type\&quot;:\&quot;String\&quot;},  \&quot;iotda::certificate::organization\&quot;:{\&quot;type\&quot;:\&quot;String\&quot;},  \&quot;iotda::certificate::organizational_unit\&quot;:{\&quot;type\&quot;:\&quot;String\&quot;},  \&quot;iotda::certificate::distinguished_name_qualifier\&quot;:{\&quot;type\&quot;:\&quot;String\&quot;},  \&quot;iotda::certificate::state_name\&quot;:{\&quot;type\&quot;:\&quot;String\&quot;},  \&quot;iotda::certificate::common_name\&quot;:{\&quot;type\&quot;:\&quot;String\&quot;},  \&quot;iotda::certificate::serial_number\&quot;:{\&quot;type\&quot;:\&quot;String\&quot;}}&#39;
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Object Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateResource Resources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProvisioningTemplateBody {\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProvisioningTemplateBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProvisioningTemplateBody input)
        {
            if (input == null) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && !this.Parameters.Equals(input.Parameters))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && !this.Resources.Equals(input.Resources))) return false;

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
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                return hashCode;
            }
        }
    }
}
