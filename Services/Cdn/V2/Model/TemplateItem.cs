using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// **参数解释：** 查询模板配置 **约束限制：** 不涉及
    /// </summary>
    public class TemplateItem 
    {

        /// <summary>
        /// **参数解释：** 账户ID **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// **参数解释：** 域名模板名称 **约束限制：** 不涉及 **取值范围：** - 1-100个字符 - 仅支持字母、数字、中文、下划线（_）、中横线（-） **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("tml_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TmlName { get; set; }

        /// <summary>
        /// **参数解释：** 域名模板描述 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }

        /// <summary>
        /// **参数解释：** 域名模板ID **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("tml_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TmlId { get; set; }

        /// <summary>
        /// **参数解释：** 域名模板类型 **约束限制：** 不涉及 **取值范围：** - 1: 系统预置模板 - 2: 租户自定义模板 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// **参数解释：** 修改时间 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("modify_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("configs", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateConfigs Configs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateItem {\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  tmlName: ").Append(TmlName).Append("\n");
            sb.Append("  remark: ").Append(Remark).Append("\n");
            sb.Append("  tmlId: ").Append(TmlId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  modifyTime: ").Append(ModifyTime).Append("\n");
            sb.Append("  configs: ").Append(Configs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateItem input)
        {
            if (input == null) return false;
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;
            if (this.TmlName != input.TmlName || (this.TmlName != null && !this.TmlName.Equals(input.TmlName))) return false;
            if (this.Remark != input.Remark || (this.Remark != null && !this.Remark.Equals(input.Remark))) return false;
            if (this.TmlId != input.TmlId || (this.TmlId != null && !this.TmlId.Equals(input.TmlId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.ModifyTime != input.ModifyTime || (this.ModifyTime != null && !this.ModifyTime.Equals(input.ModifyTime))) return false;
            if (this.Configs != input.Configs || (this.Configs != null && !this.Configs.Equals(input.Configs))) return false;

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
                if (this.AccountId != null) hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.TmlName != null) hashCode = hashCode * 59 + this.TmlName.GetHashCode();
                if (this.Remark != null) hashCode = hashCode * 59 + this.Remark.GetHashCode();
                if (this.TmlId != null) hashCode = hashCode * 59 + this.TmlId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ModifyTime != null) hashCode = hashCode * 59 + this.ModifyTime.GetHashCode();
                if (this.Configs != null) hashCode = hashCode * 59 + this.Configs.GetHashCode();
                return hashCode;
            }
        }
    }
}
