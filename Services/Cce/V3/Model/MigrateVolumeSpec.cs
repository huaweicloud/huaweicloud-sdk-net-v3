using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 服务器重装云硬盘配置
    /// </summary>
    public class MigrateVolumeSpec 
    {

        /// <summary>
        /// **参数解释**: 用户主密钥ID。 [&gt; 获取密钥ID的方法请参考：[查询密钥列表](https://support.huaweicloud.com/api-dew/ListKeys.html)](tag:hws) [&gt; 获取密钥ID的方法请参考：[查询密钥列表](https://support.huaweicloud.com/intl/zh-cn/api-dew/ListKeys.html)](tag:hws_hk)。  **约束限制**: 不涉及 **取值范围**: 不涉及 **默认取值**: 默认为空，表示云硬盘不加密。 
        /// </summary>
        [JsonProperty("cmkID", NullValueHandling = NullValueHandling.Ignore)]
        public string CmkID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrateVolumeSpec {\n");
            sb.Append("  cmkID: ").Append(CmkID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrateVolumeSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrateVolumeSpec input)
        {
            if (input == null) return false;
            if (this.CmkID != input.CmkID || (this.CmkID != null && !this.CmkID.Equals(input.CmkID))) return false;

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
                if (this.CmkID != null) hashCode = hashCode * 59 + this.CmkID.GetHashCode();
                return hashCode;
            }
        }
    }
}
