using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowCursorTimeResponse : SdkResponse
    {

        /// <summary>
        /// 游标时间值
        /// </summary>
        [JsonProperty("cursor_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CursorTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCursorTimeResponse {\n");
            sb.Append("  cursorTime: ").Append(CursorTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCursorTimeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCursorTimeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CursorTime == input.CursorTime ||
                    (this.CursorTime != null &&
                    this.CursorTime.Equals(input.CursorTime))
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
                if (this.CursorTime != null)
                    hashCode = hashCode * 59 + this.CursorTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
