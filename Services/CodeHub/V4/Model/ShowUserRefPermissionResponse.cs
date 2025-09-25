using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowUserRefPermissionResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("read", NullValueHandling = NullValueHandling.Ignore)]
        public UserRefPermissionBasicDto Read { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("review", NullValueHandling = NullValueHandling.Ignore)]
        public UserRefPermissionBasicDto Review { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("approval", NullValueHandling = NullValueHandling.Ignore)]
        public UserRefPermissionBasicDto Approval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("create_change", NullValueHandling = NullValueHandling.Ignore)]
        public UserRefPermissionBasicDto CreateChange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("merge", NullValueHandling = NullValueHandling.Ignore)]
        public UserRefPermissionBasicDto Merge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("create_delete", NullValueHandling = NullValueHandling.Ignore)]
        public UserRefPermissionBasicDto CreateDelete { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("push", NullValueHandling = NullValueHandling.Ignore)]
        public UserRefPermissionBasicDto Push { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUserRefPermissionResponse {\n");
            sb.Append("  read: ").Append(Read).Append("\n");
            sb.Append("  review: ").Append(Review).Append("\n");
            sb.Append("  approval: ").Append(Approval).Append("\n");
            sb.Append("  createChange: ").Append(CreateChange).Append("\n");
            sb.Append("  merge: ").Append(Merge).Append("\n");
            sb.Append("  createDelete: ").Append(CreateDelete).Append("\n");
            sb.Append("  push: ").Append(Push).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUserRefPermissionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUserRefPermissionResponse input)
        {
            if (input == null) return false;
            if (this.Read != input.Read || (this.Read != null && !this.Read.Equals(input.Read))) return false;
            if (this.Review != input.Review || (this.Review != null && !this.Review.Equals(input.Review))) return false;
            if (this.Approval != input.Approval || (this.Approval != null && !this.Approval.Equals(input.Approval))) return false;
            if (this.CreateChange != input.CreateChange || (this.CreateChange != null && !this.CreateChange.Equals(input.CreateChange))) return false;
            if (this.Merge != input.Merge || (this.Merge != null && !this.Merge.Equals(input.Merge))) return false;
            if (this.CreateDelete != input.CreateDelete || (this.CreateDelete != null && !this.CreateDelete.Equals(input.CreateDelete))) return false;
            if (this.Push != input.Push || (this.Push != null && !this.Push.Equals(input.Push))) return false;

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
                if (this.Read != null) hashCode = hashCode * 59 + this.Read.GetHashCode();
                if (this.Review != null) hashCode = hashCode * 59 + this.Review.GetHashCode();
                if (this.Approval != null) hashCode = hashCode * 59 + this.Approval.GetHashCode();
                if (this.CreateChange != null) hashCode = hashCode * 59 + this.CreateChange.GetHashCode();
                if (this.Merge != null) hashCode = hashCode * 59 + this.Merge.GetHashCode();
                if (this.CreateDelete != null) hashCode = hashCode * 59 + this.CreateDelete.GetHashCode();
                if (this.Push != null) hashCode = hashCode * 59 + this.Push.GetHashCode();
                return hashCode;
            }
        }
    }
}
