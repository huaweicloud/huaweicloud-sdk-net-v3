using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 节目信息。
    /// </summary>
    public class ProgramResponseBase 
    {

        /// <summary>
        /// 节目ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 更新者。
        /// </summary>
        [JsonProperty("lastUpdatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("updateTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 节目名称。
        /// </summary>
        [JsonProperty("programName", NullValueHandling = NullValueHandling.Ignore)]
        public string ProgramName { get; set; }

        /// <summary>
        /// 节目的总素材大小（含单位）。
        /// </summary>
        [JsonProperty("materialSizeStr", NullValueHandling = NullValueHandling.Ignore)]
        public string MaterialSizeStr { get; set; }

        /// <summary>
        /// 节目的总播放时长，单位秒。
        /// </summary>
        [JsonProperty("playTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? PlayTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgramResponseBase {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  lastUpdatedBy: ").Append(LastUpdatedBy).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  programName: ").Append(ProgramName).Append("\n");
            sb.Append("  materialSizeStr: ").Append(MaterialSizeStr).Append("\n");
            sb.Append("  playTime: ").Append(PlayTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProgramResponseBase);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProgramResponseBase input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.LastUpdatedBy != input.LastUpdatedBy || (this.LastUpdatedBy != null && !this.LastUpdatedBy.Equals(input.LastUpdatedBy))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.ProgramName != input.ProgramName || (this.ProgramName != null && !this.ProgramName.Equals(input.ProgramName))) return false;
            if (this.MaterialSizeStr != input.MaterialSizeStr || (this.MaterialSizeStr != null && !this.MaterialSizeStr.Equals(input.MaterialSizeStr))) return false;
            if (this.PlayTime != input.PlayTime || (this.PlayTime != null && !this.PlayTime.Equals(input.PlayTime))) return false;

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
                if (this.LastUpdatedBy != null) hashCode = hashCode * 59 + this.LastUpdatedBy.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.ProgramName != null) hashCode = hashCode * 59 + this.ProgramName.GetHashCode();
                if (this.MaterialSizeStr != null) hashCode = hashCode * 59 + this.MaterialSizeStr.GetHashCode();
                if (this.PlayTime != null) hashCode = hashCode * 59 + this.PlayTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
