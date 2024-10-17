using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Statement 
    {

        /// <summary>
        /// Statement语句的ID。 Statement语句ID必须是唯一的，例如statement01、statement02。
        /// </summary>
        [JsonProperty("Sid", NullValueHandling = NullValueHandling.Ignore)]
        public string Sid { get; set; }

        /// <summary>
        /// Statement语句的效果。“Allow”或者“Deny”。
        /// </summary>
        [JsonProperty("Effect", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect { get; set; }

        /// <summary>
        /// Statement语句作用的对象。 目前支持“CSP”和“Service”两类对象。  “CSP”对象指的是其他用户，可以作用于多个用户。  “Service”对象指的是云服务，可以作用于多个云服务。  Principal元素和NotPrincipal元素两者任选其一。选定后， “CSP”对象填写内容的格式为urn:csp:iam::domainId:root或“\\*”，其中domainId为其他用户的“帐号ID”，“\\*”指作用于所有人。  “Service”对象填写内容的格式为小写的云服务名称缩写。
        /// </summary>
        [JsonProperty("Principal", NullValueHandling = NullValueHandling.Ignore)]
        public string Principal { get; set; }

        /// <summary>
        /// NotPrincipal：Statement语句排除作用的对象。  目前支持“CSP”和“Service”两类对象。  “CSP”对象指的是其他用户，可以作用于多个用户。  “Service”对象指的是云服务，可以作用于多个云服务。  Principal元素和NotPrincipal元素两者任选其一。选定后， “CSP”对象填写内容的格式为urn:csp:iam::domainId:root或“\\*”，其中domainId为其他用户的“帐号ID”，“\\*”指作用于所有人。  “Service”对象填写内容的格式为小写的云服务名称缩写。
        /// </summary>
        [JsonProperty("NotPrincipal", NullValueHandling = NullValueHandling.Ignore)]
        public string NotPrincipal { get; set; }

        /// <summary>
        /// Statement语句作用的操作。  允许使用通配符来表示一类操作，例如：SMN:Update*、SMN:Delete*。如果只填写“*”，表示Statement语句作用的操作为该资源支持的所有操作。  Action元素和NotAction元素两者任选其一。  目前支持的操作有：  SMN:UpdateTopic SMN:DeleteTopic SMN:QueryTopicDetail SMN:ListTopicAttributes SMN:UpdateTopicAttribute SMN:DeleteTopicAttributes SMN:DeleteTopicAttributeByName SMN:ListSubscriptionsByTopic SMN:Subscribe SMN:Unsubscribe SMN:Publish
        /// </summary>
        [JsonProperty("Action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// Statement语句排除作用的操作。  允许使用通配符来表示一类操作，例如：SMN:Update*、SMN:Delete*。如果只填写“*”，表示Statement语句作用的操作为该资源支持的所有操作。  Action元素和NotAction元素两者任选其一。  目前支持的操作有：  SMN:UpdateTopic  SMN:DeleteTopic  SMN:QueryTopicDetail  SMN:ListTopicAttributes  SMN:UpdateTopicAttribute  SMN:DeleteTopicAttributes  SMN:DeleteTopicAttributeByName  SMN:ListSubscriptionsByTopic  SMN:Subscribe  SMN:Unsubscribe  SMN:Publish
        /// </summary>
        [JsonProperty("NotAction", NullValueHandling = NullValueHandling.Ignore)]
        public string NotAction { get; set; }

        /// <summary>
        /// Statement语句作用的主题。  Resource和NotResource两者任选其一。选定后，填写内容为主题URN。
        /// </summary>
        [JsonProperty("Resource", NullValueHandling = NullValueHandling.Ignore)]
        public string Resource { get; set; }

        /// <summary>
        /// Statement语句排除作用的主题。  Resource和NotResource两者任选其一。选定后，填写内容为主题URN。
        /// </summary>
        [JsonProperty("NotResource", NullValueHandling = NullValueHandling.Ignore)]
        public string NotResource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Statement {\n");
            sb.Append("  sid: ").Append(Sid).Append("\n");
            sb.Append("  effect: ").Append(Effect).Append("\n");
            sb.Append("  principal: ").Append(Principal).Append("\n");
            sb.Append("  notPrincipal: ").Append(NotPrincipal).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  notAction: ").Append(NotAction).Append("\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("  notResource: ").Append(NotResource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Statement);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Statement input)
        {
            if (input == null) return false;
            if (this.Sid != input.Sid || (this.Sid != null && !this.Sid.Equals(input.Sid))) return false;
            if (this.Effect != input.Effect || (this.Effect != null && !this.Effect.Equals(input.Effect))) return false;
            if (this.Principal != input.Principal || (this.Principal != null && !this.Principal.Equals(input.Principal))) return false;
            if (this.NotPrincipal != input.NotPrincipal || (this.NotPrincipal != null && !this.NotPrincipal.Equals(input.NotPrincipal))) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.NotAction != input.NotAction || (this.NotAction != null && !this.NotAction.Equals(input.NotAction))) return false;
            if (this.Resource != input.Resource || (this.Resource != null && !this.Resource.Equals(input.Resource))) return false;
            if (this.NotResource != input.NotResource || (this.NotResource != null && !this.NotResource.Equals(input.NotResource))) return false;

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
                if (this.Sid != null) hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.Effect != null) hashCode = hashCode * 59 + this.Effect.GetHashCode();
                if (this.Principal != null) hashCode = hashCode * 59 + this.Principal.GetHashCode();
                if (this.NotPrincipal != null) hashCode = hashCode * 59 + this.NotPrincipal.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.NotAction != null) hashCode = hashCode * 59 + this.NotAction.GetHashCode();
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.NotResource != null) hashCode = hashCode * 59 + this.NotResource.GetHashCode();
                return hashCode;
            }
        }
    }
}
