using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 对比结果。
    /// </summary>
    public class FlowCompareData 
    {

        /// <summary>
        /// 源数据库名称。
        /// </summary>
        [JsonProperty("src_db", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcDb { get; set; }

        /// <summary>
        /// 源对象名称。
        /// </summary>
        [JsonProperty("src_tb", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcTb { get; set; }

        /// <summary>
        /// 目标数据库名称。
        /// </summary>
        [JsonProperty("dst_db", NullValueHandling = NullValueHandling.Ignore)]
        public string DstDb { get; set; }

        /// <summary>
        /// 目标对象名称。
        /// </summary>
        [JsonProperty("dst_tb", NullValueHandling = NullValueHandling.Ignore)]
        public string DstTb { get; set; }

        /// <summary>
        /// 进度，1-100。
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public int? Progress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowCompareData {\n");
            sb.Append("  srcDb: ").Append(SrcDb).Append("\n");
            sb.Append("  srcTb: ").Append(SrcTb).Append("\n");
            sb.Append("  dstDb: ").Append(DstDb).Append("\n");
            sb.Append("  dstTb: ").Append(DstTb).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlowCompareData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlowCompareData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SrcDb == input.SrcDb ||
                    (this.SrcDb != null &&
                    this.SrcDb.Equals(input.SrcDb))
                ) && 
                (
                    this.SrcTb == input.SrcTb ||
                    (this.SrcTb != null &&
                    this.SrcTb.Equals(input.SrcTb))
                ) && 
                (
                    this.DstDb == input.DstDb ||
                    (this.DstDb != null &&
                    this.DstDb.Equals(input.DstDb))
                ) && 
                (
                    this.DstTb == input.DstTb ||
                    (this.DstTb != null &&
                    this.DstTb.Equals(input.DstTb))
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
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
                if (this.SrcDb != null)
                    hashCode = hashCode * 59 + this.SrcDb.GetHashCode();
                if (this.SrcTb != null)
                    hashCode = hashCode * 59 + this.SrcTb.GetHashCode();
                if (this.DstDb != null)
                    hashCode = hashCode * 59 + this.DstDb.GetHashCode();
                if (this.DstTb != null)
                    hashCode = hashCode * 59 + this.DstTb.GetHashCode();
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                return hashCode;
            }
        }
    }
}
