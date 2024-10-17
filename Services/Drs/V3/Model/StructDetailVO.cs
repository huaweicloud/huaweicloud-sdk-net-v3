using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 灾备初始化对象详情信息体
    /// </summary>
    public class StructDetailVO 
    {

        /// <summary>
        /// 进度
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public int? Progress { get; set; }

        /// <summary>
        /// 源数据库名称
        /// </summary>
        [JsonProperty("src_DB", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcDB { get; set; }

        /// <summary>
        /// 源对象名称
        /// </summary>
        [JsonProperty("src_TB", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcTB { get; set; }

        /// <summary>
        /// 目标数据库名称
        /// </summary>
        [JsonProperty("dst_DB", NullValueHandling = NullValueHandling.Ignore)]
        public string DstDB { get; set; }

        /// <summary>
        /// 目标对象名称
        /// </summary>
        [JsonProperty("dst_TB", NullValueHandling = NullValueHandling.Ignore)]
        public string DstTB { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StructDetailVO {\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  srcDB: ").Append(SrcDB).Append("\n");
            sb.Append("  srcTB: ").Append(SrcTB).Append("\n");
            sb.Append("  dstDB: ").Append(DstDB).Append("\n");
            sb.Append("  dstTB: ").Append(DstTB).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StructDetailVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StructDetailVO input)
        {
            if (input == null) return false;
            if (this.Progress != input.Progress || (this.Progress != null && !this.Progress.Equals(input.Progress))) return false;
            if (this.SrcDB != input.SrcDB || (this.SrcDB != null && !this.SrcDB.Equals(input.SrcDB))) return false;
            if (this.SrcTB != input.SrcTB || (this.SrcTB != null && !this.SrcTB.Equals(input.SrcTB))) return false;
            if (this.DstDB != input.DstDB || (this.DstDB != null && !this.DstDB.Equals(input.DstDB))) return false;
            if (this.DstTB != input.DstTB || (this.DstTB != null && !this.DstTB.Equals(input.DstTB))) return false;

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
                if (this.Progress != null) hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.SrcDB != null) hashCode = hashCode * 59 + this.SrcDB.GetHashCode();
                if (this.SrcTB != null) hashCode = hashCode * 59 + this.SrcTB.GetHashCode();
                if (this.DstDB != null) hashCode = hashCode * 59 + this.DstDB.GetHashCode();
                if (this.DstTB != null) hashCode = hashCode * 59 + this.DstTB.GetHashCode();
                return hashCode;
            }
        }
    }
}
