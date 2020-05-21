using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 用户自定义键值对
    /// </summary>
    public class MetaData 
    {

        /// <summary>
        /// 用户自定义数据总长度不大于512字节。用户自定义键不能是空串，不能包含符号.，以及不能以符号$开头。说明：Windows弹性云服务器Administrator用户的密码。示例：键（固定）：admin_pass值：cloud.1234创建密码方式鉴权的Windows弹性云服务器时为必选字段。
        /// </summary>
        [JsonProperty("customize_key", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomizeKey { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetaData {\n");
            sb.Append("  customizeKey: ").Append(CustomizeKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetaData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetaData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomizeKey == input.CustomizeKey ||
                    (this.CustomizeKey != null &&
                    this.CustomizeKey.Equals(input.CustomizeKey))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CustomizeKey != null)
                    hashCode = hashCode * 59 + this.CustomizeKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
