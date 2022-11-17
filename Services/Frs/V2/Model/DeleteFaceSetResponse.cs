using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DeleteFaceSetResponse : SdkResponse
    {

        /// <summary>
        /// 人脸库名称。 调用失败时无此字段。
        /// </summary>
        [JsonProperty("face_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceSetName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteFaceSetResponse {\n");
            sb.Append("  faceSetName: ").Append(FaceSetName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteFaceSetResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteFaceSetResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FaceSetName == input.FaceSetName ||
                    (this.FaceSetName != null &&
                    this.FaceSetName.Equals(input.FaceSetName))
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
                if (this.FaceSetName != null)
                    hashCode = hashCode * 59 + this.FaceSetName.GetHashCode();
                return hashCode;
            }
        }
    }
}
