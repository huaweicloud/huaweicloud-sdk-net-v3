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
    /// **参数解释：** 项目。 **取值范围：** 不涉及。
    /// </summary>
    public class BatchUpdateResponseResultProject 
    {

        /// <summary>
        /// **参数解释：** 项目数字id。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 项目uuid。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// **参数解释：** 批量编辑工作项的总数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释：** 项目是否关闭。 **取值范围：** 0（打开） 1（关闭）
        /// </summary>
        [JsonProperty("close", NullValueHandling = NullValueHandling.Ignore)]
        public int? Close { get; set; }

        /// <summary>
        /// **参数解释：** 批量编辑数量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public int? Role { get; set; }

        /// <summary>
        /// **参数解释：** 工作项类型。 **取值范围：** scrum。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释：** 工作项是否归档。 **取值范围：** true(归档) false(未归档)
        /// </summary>
        [JsonProperty("archive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Archive { get; set; }

        /// <summary>
        /// **参数解释：** 项目数量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("mem_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateResponseResultProject {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  identifier: ").Append(Identifier).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  close: ").Append(Close).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  archive: ").Append(Archive).Append("\n");
            sb.Append("  memCount: ").Append(MemCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateResponseResultProject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateResponseResultProject input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Identifier != input.Identifier || (this.Identifier != null && !this.Identifier.Equals(input.Identifier))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Close != input.Close || (this.Close != null && !this.Close.Equals(input.Close))) return false;
            if (this.Role != input.Role || (this.Role != null && !this.Role.Equals(input.Role))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Archive != input.Archive || (this.Archive != null && !this.Archive.Equals(input.Archive))) return false;
            if (this.MemCount != input.MemCount || (this.MemCount != null && !this.MemCount.Equals(input.MemCount))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Identifier != null) hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Close != null) hashCode = hashCode * 59 + this.Close.GetHashCode();
                if (this.Role != null) hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Archive != null) hashCode = hashCode * 59 + this.Archive.GetHashCode();
                if (this.MemCount != null) hashCode = hashCode * 59 + this.MemCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
