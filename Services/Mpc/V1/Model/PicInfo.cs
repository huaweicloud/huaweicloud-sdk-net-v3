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
    public class PicInfo 
    {

        /// <summary>
        /// 截图文件名。 
        /// </summary>
        [JsonProperty("pic_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PicName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PicInfo {\n");
            sb.Append("  picName: ").Append(PicName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PicInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PicInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PicName == input.PicName ||
                    (this.PicName != null &&
                    this.PicName.Equals(input.PicName))
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
                if (this.PicName != null)
                    hashCode = hashCode * 59 + this.PicName.GetHashCode();
                return hashCode;
            }
        }
    }
}
