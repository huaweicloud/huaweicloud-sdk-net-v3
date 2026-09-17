using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListPlanRequest 
    {

        /// <summary>
        /// 项目32位ID，项目唯一标识。通过查询IPD项目列表获取，响应消息体中的id字段的值就是项目ID。
        /// </summary>
        [SDKProperty("project_id", IsPath = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释：** 发布/迭代名称 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("key_word", IsQuery = true)]
        [JsonProperty("key_word", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyWord { get; set; }

        /// <summary>
        /// **参数解释：** 更新发布/迭代时间，unix时间戳，单位：毫秒  样例：1576114296000,1576114396000 **约束限制：**  起止时间均为13位的时间戳字符串，使用英文逗号分割。 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("updated_time_interval", IsQuery = true)]
        [JsonProperty("updated_time_interval", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedTimeInterval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPlanRequest {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  keyWord: ").Append(KeyWord).Append("\n");
            sb.Append("  updatedTimeInterval: ").Append(UpdatedTimeInterval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPlanRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPlanRequest input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.KeyWord != input.KeyWord || (this.KeyWord != null && !this.KeyWord.Equals(input.KeyWord))) return false;
            if (this.UpdatedTimeInterval != input.UpdatedTimeInterval || (this.UpdatedTimeInterval != null && !this.UpdatedTimeInterval.Equals(input.UpdatedTimeInterval))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.KeyWord != null) hashCode = hashCode * 59 + this.KeyWord.GetHashCode();
                if (this.UpdatedTimeInterval != null) hashCode = hashCode * 59 + this.UpdatedTimeInterval.GetHashCode();
                return hashCode;
            }
        }
    }
}
