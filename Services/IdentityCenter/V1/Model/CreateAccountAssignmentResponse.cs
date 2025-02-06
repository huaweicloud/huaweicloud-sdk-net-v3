using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateAccountAssignmentResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("account_assignment_creation_status", NullValueHandling = NullValueHandling.Ignore)]
        public AccountAssignmentOperationStatusDto AccountAssignmentCreationStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAccountAssignmentResponse {\n");
            sb.Append("  accountAssignmentCreationStatus: ").Append(AccountAssignmentCreationStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAccountAssignmentResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAccountAssignmentResponse input)
        {
            if (input == null) return false;
            if (this.AccountAssignmentCreationStatus != input.AccountAssignmentCreationStatus || (this.AccountAssignmentCreationStatus != null && !this.AccountAssignmentCreationStatus.Equals(input.AccountAssignmentCreationStatus))) return false;

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
                if (this.AccountAssignmentCreationStatus != null) hashCode = hashCode * 59 + this.AccountAssignmentCreationStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
