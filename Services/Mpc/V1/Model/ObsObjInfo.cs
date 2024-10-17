using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ObsObjInfo 
    {

        /// <summary>
        /// OBS的bucket名称。 
        /// </summary>
        [JsonProperty("bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string Bucket { get; set; }

        /// <summary>
        /// OBS桶所在的区域，且必须与使用的MPC区域保持一致。 
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// OBS对象路径，遵守OSS Object定义。  - 当用于指示input时,需要指定到具体对象。 - 当用于指示output时, 只需指定到转码结果期望存放的路径。 
        /// </summary>
        [JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
        public string Object { get; set; }

        /// <summary>
        /// 文件名，仅用于转封装指定输出名称。  - 当指定了此参数时，输出的对象名为object/file_name 。 - 当不指定此参数时，输出的对象名为object/xxx，其中xxx由MPC指定。 
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObsObjInfo {\n");
            sb.Append("  bucket: ").Append(Bucket).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObsObjInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObsObjInfo input)
        {
            if (input == null) return false;
            if (this.Bucket != input.Bucket || (this.Bucket != null && !this.Bucket.Equals(input.Bucket))) return false;
            if (this.Location != input.Location || (this.Location != null && !this.Location.Equals(input.Location))) return false;
            if (this.Object != input.Object || (this.Object != null && !this.Object.Equals(input.Object))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;

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
                if (this.Bucket != null) hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                if (this.Location != null) hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Object != null) hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                return hashCode;
            }
        }
    }
}
