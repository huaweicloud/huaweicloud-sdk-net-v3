using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Tms.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListTagsRequest 
    {
        /// <summary>
        /// 标签类型
        /// </summary>
        /// <value>标签类型</value>
        [JsonConverter(typeof(EnumClassConverter<TagTypesEnum>))]
        public class TagTypesEnum
        {
            /// <summary>
            /// Enum RESOURCE for value: resource
            /// </summary>
            public static readonly TagTypesEnum RESOURCE = new TagTypesEnum("resource");

            private static readonly Dictionary<string, TagTypesEnum> StaticFields =
            new Dictionary<string, TagTypesEnum>()
            {
                { "resource", RESOURCE },
            };

            private string _value;

            public TagTypesEnum()
            {

            }

            public TagTypesEnum(string value)
            {
                _value = value;
            }

            public static TagTypesEnum FromValue(string value)
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

                if (this.Equals(obj as TagTypesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TagTypesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TagTypesEnum a, TagTypesEnum b)
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

            public static bool operator !=(TagTypesEnum a, TagTypesEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 资源类型
        /// </summary>
        [SDKProperty("resource_types", IsQuery = true)]
        [JsonProperty("resource_types", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypes { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [SDKProperty("project_id", IsQuery = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 标签类型
        /// </summary>
        [SDKProperty("tag_types", IsQuery = true)]
        [JsonProperty("tag_types", NullValueHandling = NullValueHandling.Ignore)]
        public TagTypesEnum TagTypes { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTagsRequest {\n");
            sb.Append("  resourceTypes: ").Append(ResourceTypes).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  tagTypes: ").Append(TagTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTagsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTagsRequest input)
        {
            if (input == null) return false;
            if (this.ResourceTypes != input.ResourceTypes || (this.ResourceTypes != null && !this.ResourceTypes.Equals(input.ResourceTypes))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.TagTypes != input.TagTypes) return false;

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
                if (this.ResourceTypes != null) hashCode = hashCode * 59 + this.ResourceTypes.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                hashCode = hashCode * 59 + this.TagTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
