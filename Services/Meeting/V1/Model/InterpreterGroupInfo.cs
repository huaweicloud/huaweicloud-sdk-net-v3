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
    /// 传译组信息
    /// </summary>
    public class InterpreterGroupInfo 
    {

        /// <summary>
        /// 传译组序号。
        /// </summary>
        [JsonProperty("groupID", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupID { get; set; }

        /// <summary>
        /// 传译组名称。
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 传译组类型，MANUAL：人工传译，AI：AI传译。默认MANUAL。
        /// </summary>
        [JsonProperty("groupType", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupType { get; set; }

        /// <summary>
        /// 传译组支持的第一种语言。
        /// </summary>
        [JsonProperty("firstLanguage", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstLanguage { get; set; }

        /// <summary>
        /// 传译组支持的第二种语言。
        /// </summary>
        [JsonProperty("secondLanguage", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondLanguage { get; set; }

        /// <summary>
        /// 传译员列表。
        /// </summary>
        [JsonProperty("interpreters", NullValueHandling = NullValueHandling.Ignore)]
        public List<InterpreterInfo> Interpreters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InterpreterGroupInfo {\n");
            sb.Append("  groupID: ").Append(GroupID).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  groupType: ").Append(GroupType).Append("\n");
            sb.Append("  firstLanguage: ").Append(FirstLanguage).Append("\n");
            sb.Append("  secondLanguage: ").Append(SecondLanguage).Append("\n");
            sb.Append("  interpreters: ").Append(Interpreters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InterpreterGroupInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InterpreterGroupInfo input)
        {
            if (input == null) return false;
            if (this.GroupID != input.GroupID || (this.GroupID != null && !this.GroupID.Equals(input.GroupID))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.GroupType != input.GroupType || (this.GroupType != null && !this.GroupType.Equals(input.GroupType))) return false;
            if (this.FirstLanguage != input.FirstLanguage || (this.FirstLanguage != null && !this.FirstLanguage.Equals(input.FirstLanguage))) return false;
            if (this.SecondLanguage != input.SecondLanguage || (this.SecondLanguage != null && !this.SecondLanguage.Equals(input.SecondLanguage))) return false;
            if (this.Interpreters != input.Interpreters || (this.Interpreters != null && input.Interpreters != null && !this.Interpreters.SequenceEqual(input.Interpreters))) return false;

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
                if (this.GroupID != null) hashCode = hashCode * 59 + this.GroupID.GetHashCode();
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.GroupType != null) hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.FirstLanguage != null) hashCode = hashCode * 59 + this.FirstLanguage.GetHashCode();
                if (this.SecondLanguage != null) hashCode = hashCode * 59 + this.SecondLanguage.GetHashCode();
                if (this.Interpreters != null) hashCode = hashCode * 59 + this.Interpreters.GetHashCode();
                return hashCode;
            }
        }
    }
}
