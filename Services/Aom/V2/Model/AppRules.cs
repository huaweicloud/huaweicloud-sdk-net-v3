using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 服务参数。
    /// </summary>
    public class AppRules 
    {

        /// <summary>
        /// 规则创建时间(创建时不传，修改时传查询返回的createTime)。
        /// </summary>
        [JsonProperty("createTime", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// true、false 规则是否启用。
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// aom_inventory_rules_event规则事件名称，对于服务发现固定为\&quot;aom_inventory_rules_event\&quot;。
        /// </summary>
        [JsonProperty("eventName", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        /// <summary>
        /// 主机ID（暂不使用，传空即可）。
        /// </summary>
        [JsonProperty("hostid", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Hostid { get; set; }

        /// <summary>
        /// 创建时填空，修改时填规则ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 规则名称。 字符长度为4到63位，以小写字母a-z开头，只能包含0-9/a-z/-，不能以-结尾。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 租户从IAM申请到的projectid，一般为32位字符串。
        /// </summary>
        [JsonProperty("projectid", NullValueHandling = NullValueHandling.Ignore)]
        public string Projectid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public AppRulesSpec Spec { get; set; }

        /// <summary>
        /// 自定义描述信息
        /// </summary>
        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppRules {\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  eventName: ").Append(EventName).Append("\n");
            sb.Append("  hostid: ").Append(Hostid).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectid: ").Append(Projectid).Append("\n");
            sb.Append("  spec: ").Append(Spec).Append("\n");
            sb.Append("  desc: ").Append(Desc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppRules);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppRules input)
        {
            if (input == null) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.EventName != input.EventName || (this.EventName != null && !this.EventName.Equals(input.EventName))) return false;
            if (this.Hostid != input.Hostid || (this.Hostid != null && input.Hostid != null && !this.Hostid.SequenceEqual(input.Hostid))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Projectid != input.Projectid || (this.Projectid != null && !this.Projectid.Equals(input.Projectid))) return false;
            if (this.Spec != input.Spec || (this.Spec != null && !this.Spec.Equals(input.Spec))) return false;
            if (this.Desc != input.Desc || (this.Desc != null && !this.Desc.Equals(input.Desc))) return false;

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
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.EventName != null) hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.Hostid != null) hashCode = hashCode * 59 + this.Hostid.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Projectid != null) hashCode = hashCode * 59 + this.Projectid.GetHashCode();
                if (this.Spec != null) hashCode = hashCode * 59 + this.Spec.GetHashCode();
                if (this.Desc != null) hashCode = hashCode * 59 + this.Desc.GetHashCode();
                return hashCode;
            }
        }
    }
}
