using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// The request body of update group request.
    /// </summary>
    public class UpdateGroupReqBody 
    {

        /// <summary>
        /// 用户组名，长度为1到128个字符，可包含中文、英文、数字、空格、\&quot;_\&quot;、\&quot;-\&quot;、\&quot;{\&quot;和\&quot;}\&quot;的字符串。
        /// </summary>
        [JsonProperty("new_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NewGroupName { get; set; }

        /// <summary>
        /// 用户组描述信息，长度为0到255字符，不能包含特定字符\&quot;@\&quot;、\&quot;#\&quot;、\&quot;%\&quot;、\&quot;&amp;\&quot;、\&quot;&lt;\&quot;、\&quot;&gt;\&quot;、\&quot;\\\\\&quot;、\&quot;$\&quot;、\&quot;^\&quot;和\&quot;*\&quot;的字符串。
        /// </summary>
        [JsonProperty("new_group_description", NullValueHandling = NullValueHandling.Ignore)]
        public string NewGroupDescription { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateGroupReqBody {\n");
            sb.Append("  newGroupName: ").Append(NewGroupName).Append("\n");
            sb.Append("  newGroupDescription: ").Append(NewGroupDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateGroupReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateGroupReqBody input)
        {
            if (input == null) return false;
            if (this.NewGroupName != input.NewGroupName || (this.NewGroupName != null && !this.NewGroupName.Equals(input.NewGroupName))) return false;
            if (this.NewGroupDescription != input.NewGroupDescription || (this.NewGroupDescription != null && !this.NewGroupDescription.Equals(input.NewGroupDescription))) return false;

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
                if (this.NewGroupName != null) hashCode = hashCode * 59 + this.NewGroupName.GetHashCode();
                if (this.NewGroupDescription != null) hashCode = hashCode * 59 + this.NewGroupDescription.GetHashCode();
                return hashCode;
            }
        }
    }
}
