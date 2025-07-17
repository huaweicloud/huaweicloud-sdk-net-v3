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
    /// 更新节目详情响应
    /// </summary>
    public class UpdateProgramRequestDTO 
    {

        /// <summary>
        /// 节目名称。
        /// </summary>
        [JsonProperty("programName", NullValueHandling = NullValueHandling.Ignore)]
        public string ProgramName { get; set; }

        /// <summary>
        /// 节目素材列表。
        /// </summary>
        [JsonProperty("programItemList", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProgramItemRequestBase> ProgramItemList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateProgramRequestDTO {\n");
            sb.Append("  programName: ").Append(ProgramName).Append("\n");
            sb.Append("  programItemList: ").Append(ProgramItemList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateProgramRequestDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateProgramRequestDTO input)
        {
            if (input == null) return false;
            if (this.ProgramName != input.ProgramName || (this.ProgramName != null && !this.ProgramName.Equals(input.ProgramName))) return false;
            if (this.ProgramItemList != input.ProgramItemList || (this.ProgramItemList != null && input.ProgramItemList != null && !this.ProgramItemList.SequenceEqual(input.ProgramItemList))) return false;

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
                if (this.ProgramName != null) hashCode = hashCode * 59 + this.ProgramName.GetHashCode();
                if (this.ProgramItemList != null) hashCode = hashCode * 59 + this.ProgramItemList.GetHashCode();
                return hashCode;
            }
        }
    }
}
