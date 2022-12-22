using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ImageSearch.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class RunCheckPictureResponse : SdkResponse
    {

        /// <summary>
        /// 调用成功时表示调用结果。  调用失败时无此字段。  - true表示图像索引库中存在查询的图片。  - false表示图像索引库中不存在查询的图片。 
        /// </summary>
        [JsonProperty("exist", NullValueHandling = NullValueHandling.Ignore)]
        public string Exist { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunCheckPictureResponse {\n");
            sb.Append("  exist: ").Append(Exist).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RunCheckPictureResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RunCheckPictureResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Exist == input.Exist ||
                    (this.Exist != null &&
                    this.Exist.Equals(input.Exist))
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
                if (this.Exist != null)
                    hashCode = hashCode * 59 + this.Exist.GetHashCode();
                return hashCode;
            }
        }
    }
}
