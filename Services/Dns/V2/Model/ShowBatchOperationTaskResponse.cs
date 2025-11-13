using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBatchOperationTaskResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 批量操作任务的ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 任务类型。 **取值范围：** - batch_create_zone：批量添加域名 - create：批量添加记录集 - import_recordset：批量导入记录集 - delete：批量删除记录集 - batch_update_rs：批量修改记录集 - transfer：批量转移域名
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释：** 任务状态。 **取值范围：** - PENDING：执行中 - DONE：已完成
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** 任务的创建时间。 格式：yyyy-MM-dd HH:mm:ss。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 批量操作成功的数量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("success_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// **参数解释：** 批量操作失败的数量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("error_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ErrorCount { get; set; }

        /// <summary>
        /// 批量操作任务列表。
        /// </summary>
        [JsonProperty("error_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowBatchOperationTaskErrorItem> ErrorItems { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBatchOperationTaskResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  successCount: ").Append(SuccessCount).Append("\n");
            sb.Append("  errorCount: ").Append(ErrorCount).Append("\n");
            sb.Append("  errorItems: ").Append(ErrorItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBatchOperationTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBatchOperationTaskResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.SuccessCount != input.SuccessCount || (this.SuccessCount != null && !this.SuccessCount.Equals(input.SuccessCount))) return false;
            if (this.ErrorCount != input.ErrorCount || (this.ErrorCount != null && !this.ErrorCount.Equals(input.ErrorCount))) return false;
            if (this.ErrorItems != input.ErrorItems || (this.ErrorItems != null && input.ErrorItems != null && !this.ErrorItems.SequenceEqual(input.ErrorItems))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.SuccessCount != null) hashCode = hashCode * 59 + this.SuccessCount.GetHashCode();
                if (this.ErrorCount != null) hashCode = hashCode * 59 + this.ErrorCount.GetHashCode();
                if (this.ErrorItems != null) hashCode = hashCode * 59 + this.ErrorItems.GetHashCode();
                return hashCode;
            }
        }
    }
}
