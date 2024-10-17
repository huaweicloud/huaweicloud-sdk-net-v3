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
    /// 主机组标签信息
    /// </summary>
    public class GetHostGroupListTag 
    {
        /// <summary>
        /// 标签类型。AND：标签过滤的逻辑为与，OR：标签过滤的逻辑为或
        /// </summary>
        /// <value>标签类型。AND：标签过滤的逻辑为与，OR：标签过滤的逻辑为或</value>
        [JsonConverter(typeof(EnumClassConverter<TagTypeEnum>))]
        public class TagTypeEnum
        {
            /// <summary>
            /// Enum AND for value: AND
            /// </summary>
            public static readonly TagTypeEnum AND = new TagTypeEnum("AND");

            /// <summary>
            /// Enum OR for value: OR
            /// </summary>
            public static readonly TagTypeEnum OR = new TagTypeEnum("OR");

            private static readonly Dictionary<string, TagTypeEnum> StaticFields =
            new Dictionary<string, TagTypeEnum>()
            {
                { "AND", AND },
                { "OR", OR },
            };

            private string _value;

            public TagTypeEnum()
            {

            }

            public TagTypeEnum(string value)
            {
                _value = value;
            }

            public static TagTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TagTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TagTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TagTypeEnum a, TagTypeEnum b)
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

            public static bool operator !=(TagTypeEnum a, TagTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 标签类型。AND：标签过滤的逻辑为与，OR：标签过滤的逻辑为或
        /// </summary>
        [JsonProperty("tag_type", NullValueHandling = NullValueHandling.Ignore)]
        public TagTypeEnum TagType { get; set; }
        /// <summary>
        /// 主机组标签
        /// </summary>
        [JsonProperty("tag_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<HostGroupTag> TagList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetHostGroupListTag {\n");
            sb.Append("  tagType: ").Append(TagType).Append("\n");
            sb.Append("  tagList: ").Append(TagList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetHostGroupListTag);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetHostGroupListTag input)
        {
            if (input == null) return false;
            if (this.TagType != input.TagType) return false;
            if (this.TagList != input.TagList || (this.TagList != null && input.TagList != null && !this.TagList.SequenceEqual(input.TagList))) return false;

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
                hashCode = hashCode * 59 + this.TagType.GetHashCode();
                if (this.TagList != null) hashCode = hashCode * 59 + this.TagList.GetHashCode();
                return hashCode;
            }
        }
    }
}
