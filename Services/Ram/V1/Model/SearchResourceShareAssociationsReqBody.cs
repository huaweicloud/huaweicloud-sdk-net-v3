using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ram.V1.Model
{
    /// <summary>
    /// The request body of the SearchResourceShareAssociations operation.
    /// </summary>
    public class SearchResourceShareAssociationsReqBody 
    {
        /// <summary>
        /// 指定绑定的类型（principal或resource）。
        /// </summary>
        /// <value>指定绑定的类型（principal或resource）。</value>
        [JsonConverter(typeof(EnumClassConverter<AssociationTypeEnum>))]
        public class AssociationTypeEnum
        {
            /// <summary>
            /// Enum PRINCIPAL for value: principal
            /// </summary>
            public static readonly AssociationTypeEnum PRINCIPAL = new AssociationTypeEnum("principal");

            /// <summary>
            /// Enum RESOURCE for value: resource
            /// </summary>
            public static readonly AssociationTypeEnum RESOURCE = new AssociationTypeEnum("resource");

            private static readonly Dictionary<string, AssociationTypeEnum> StaticFields =
            new Dictionary<string, AssociationTypeEnum>()
            {
                { "principal", PRINCIPAL },
                { "resource", RESOURCE },
            };

            private string _value;

            public AssociationTypeEnum()
            {

            }

            public AssociationTypeEnum(string value)
            {
                _value = value;
            }

            public static AssociationTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as AssociationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AssociationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AssociationTypeEnum a, AssociationTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(AssociationTypeEnum a, AssociationTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 指定绑定的状态。
        /// </summary>
        [JsonProperty("association_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociationStatus { get; set; }

        /// <summary>
        /// 指定绑定的类型（principal或resource）。
        /// </summary>
        [JsonProperty("association_type", NullValueHandling = NullValueHandling.Ignore)]
        public AssociationTypeEnum AssociationType { get; set; }
        /// <summary>
        /// 分页页面的最大值。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 页面标记。
        /// </summary>
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 指定绑定的资源使用者。
        /// </summary>
        [JsonProperty("principal", NullValueHandling = NullValueHandling.Ignore)]
        public string Principal { get; set; }

        /// <summary>
        /// 指定绑定的共享资源URN。
        /// </summary>
        [JsonProperty("resource_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceUrn { get; set; }

        /// <summary>
        /// 指定资源共享实例的ID列表。
        /// </summary>
        [JsonProperty("resource_share_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceShareIds { get; set; }

        /// <summary>
        /// 指定共享资源ID列表。
        /// </summary>
        [JsonProperty("resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchResourceShareAssociationsReqBody {\n");
            sb.Append("  associationStatus: ").Append(AssociationStatus).Append("\n");
            sb.Append("  associationType: ").Append(AssociationType).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  principal: ").Append(Principal).Append("\n");
            sb.Append("  resourceUrn: ").Append(ResourceUrn).Append("\n");
            sb.Append("  resourceShareIds: ").Append(ResourceShareIds).Append("\n");
            sb.Append("  resourceIds: ").Append(ResourceIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchResourceShareAssociationsReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchResourceShareAssociationsReqBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssociationStatus == input.AssociationStatus ||
                    (this.AssociationStatus != null &&
                    this.AssociationStatus.Equals(input.AssociationStatus))
                ) && 
                (
                    this.AssociationType == input.AssociationType ||
                    (this.AssociationType != null &&
                    this.AssociationType.Equals(input.AssociationType))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.Principal == input.Principal ||
                    (this.Principal != null &&
                    this.Principal.Equals(input.Principal))
                ) && 
                (
                    this.ResourceUrn == input.ResourceUrn ||
                    (this.ResourceUrn != null &&
                    this.ResourceUrn.Equals(input.ResourceUrn))
                ) && 
                (
                    this.ResourceShareIds == input.ResourceShareIds ||
                    this.ResourceShareIds != null &&
                    input.ResourceShareIds != null &&
                    this.ResourceShareIds.SequenceEqual(input.ResourceShareIds)
                ) && 
                (
                    this.ResourceIds == input.ResourceIds ||
                    this.ResourceIds != null &&
                    input.ResourceIds != null &&
                    this.ResourceIds.SequenceEqual(input.ResourceIds)
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
                if (this.AssociationStatus != null)
                    hashCode = hashCode * 59 + this.AssociationStatus.GetHashCode();
                if (this.AssociationType != null)
                    hashCode = hashCode * 59 + this.AssociationType.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Principal != null)
                    hashCode = hashCode * 59 + this.Principal.GetHashCode();
                if (this.ResourceUrn != null)
                    hashCode = hashCode * 59 + this.ResourceUrn.GetHashCode();
                if (this.ResourceShareIds != null)
                    hashCode = hashCode * 59 + this.ResourceShareIds.GetHashCode();
                if (this.ResourceIds != null)
                    hashCode = hashCode * 59 + this.ResourceIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
