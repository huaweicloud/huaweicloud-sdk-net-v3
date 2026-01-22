using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class InsertHeaderConfig 
    {

        /// <summary>
        /// **参数解释**：请求头参数名。  **约束限制**：不能是以下字符： connection、upgrade、content-length、transfer-encoding、keep-alive、te、host、cookie、remoteip、authority、x-forwarded-host、x-forwarded-for、x-forwarded-for-port、x-forwarded-tls-certificate-id、x-forwarded-tls-protocol、x-forwarded-tls-cipher、x-forwarded-elb-ip、x-forwarded-port、x-forwarded-elb-id、x-forwarded-elb-vip、x-real-ip、x-forwarded-proto、x-nuwa-trace-ne-in、x-nuwa-trace-ne-out。  **取值范围**：1-40个字符，字母a-z（不区分大小写）、数字，短划线-和下划线_。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// **参数解释**：请求头参数类别。  **取值范围**： - USER_DEFINED：用户自定义请求头。 - REFERENCE_HEADER：引用请求头字段中的某一个字段。 - SYSTEM_DEFINED：表示请求头参数只能使用系统定义的一系列固定值，取值列表见value字段描述。
        /// </summary>
        [JsonProperty("value_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueType { get; set; }

        /// <summary>
        /// **参数解释**：请求头参数的值。  **取值范围**：1-128个字符，支持ascii码值32&lt;&#x3D;ch&lt;&#x3D;127范围内可打印字符，*和英文问号?。不能以空格开头或结尾，不允许设置值为：connection、upgrade、content-length、transfer-encoding、keep-alive、te、host、cookie、remoteip、authority、transparent、x-forwarded-host、x-forwarded-for、x-forwarded-for-port、x-forwarded-tls-certificate-id、 x-forwarded-tls-protocol、x-forwarded-tls-cipher、x-forwarded-port、x-real-ip、x-forwarded-proto、x-forwarded-elb-ip、 x-forwarded-elb-id、x-forwarded-elb-vip、x-nuwa-trace-ne-in、x-nuwa-trace-ne-out。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InsertHeaderConfig {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  valueType: ").Append(ValueType).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InsertHeaderConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InsertHeaderConfig input)
        {
            if (input == null) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.ValueType != input.ValueType || (this.ValueType != null && !this.ValueType.Equals(input.ValueType))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;

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
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.ValueType != null) hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
