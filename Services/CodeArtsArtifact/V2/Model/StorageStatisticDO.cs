using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StorageStatisticDO 
    {

        /// <summary>
        /// 参数解释: 文件总数。 取值范围: 不涉及。
        /// </summary>
        [JsonProperty("filesCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? FilesCount { get; set; }

        /// <summary>
        /// 参数解释: 占用空间(字节)。 取值范围: 不涉及。
        /// </summary>
        [JsonProperty("usedSpaceLength", NullValueHandling = NullValueHandling.Ignore)]
        public long? UsedSpaceLength { get; set; }

        /// <summary>
        /// 参数解释: 占用空间。 取值范围: 不涉及。
        /// </summary>
        [JsonProperty("usedSpace", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedSpace { get; set; }

        /// <summary>
        /// 参数解释: 统计日期。 取值范围: 不涉及。
        /// </summary>
        [JsonProperty("summaryDate", NullValueHandling = NullValueHandling.Ignore)]
        public string SummaryDate { get; set; }

        /// <summary>
        /// 参数解释: 文件夹总数。 取值范围: 不涉及。
        /// </summary>
        [JsonProperty("foldersCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? FoldersCount { get; set; }

        /// <summary>
        /// 参数解释: 文件及文件夹总数。 取值范围: 不涉及。
        /// </summary>
        [JsonProperty("itemsCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemsCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageStatisticDO {\n");
            sb.Append("  filesCount: ").Append(FilesCount).Append("\n");
            sb.Append("  usedSpaceLength: ").Append(UsedSpaceLength).Append("\n");
            sb.Append("  usedSpace: ").Append(UsedSpace).Append("\n");
            sb.Append("  summaryDate: ").Append(SummaryDate).Append("\n");
            sb.Append("  foldersCount: ").Append(FoldersCount).Append("\n");
            sb.Append("  itemsCount: ").Append(ItemsCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StorageStatisticDO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StorageStatisticDO input)
        {
            if (input == null) return false;
            if (this.FilesCount != input.FilesCount || (this.FilesCount != null && !this.FilesCount.Equals(input.FilesCount))) return false;
            if (this.UsedSpaceLength != input.UsedSpaceLength || (this.UsedSpaceLength != null && !this.UsedSpaceLength.Equals(input.UsedSpaceLength))) return false;
            if (this.UsedSpace != input.UsedSpace || (this.UsedSpace != null && !this.UsedSpace.Equals(input.UsedSpace))) return false;
            if (this.SummaryDate != input.SummaryDate || (this.SummaryDate != null && !this.SummaryDate.Equals(input.SummaryDate))) return false;
            if (this.FoldersCount != input.FoldersCount || (this.FoldersCount != null && !this.FoldersCount.Equals(input.FoldersCount))) return false;
            if (this.ItemsCount != input.ItemsCount || (this.ItemsCount != null && !this.ItemsCount.Equals(input.ItemsCount))) return false;

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
                if (this.FilesCount != null) hashCode = hashCode * 59 + this.FilesCount.GetHashCode();
                if (this.UsedSpaceLength != null) hashCode = hashCode * 59 + this.UsedSpaceLength.GetHashCode();
                if (this.UsedSpace != null) hashCode = hashCode * 59 + this.UsedSpace.GetHashCode();
                if (this.SummaryDate != null) hashCode = hashCode * 59 + this.SummaryDate.GetHashCode();
                if (this.FoldersCount != null) hashCode = hashCode * 59 + this.FoldersCount.GetHashCode();
                if (this.ItemsCount != null) hashCode = hashCode * 59 + this.ItemsCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
