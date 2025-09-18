using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 规则过滤器
    /// </summary>
    public class PolicyFilterDefinitionV2 
    {
        /// <summary>
        /// 参数tags的取值逻辑，例如tags设置了a:a和b:b，当取值AND时，表示规则仅对同时绑定了a:a和b:b的资源生效；当取值为OR时，表示规则对任何绑定了a:a或b:b的资源生效。
        /// </summary>
        /// <value>参数tags的取值逻辑，例如tags设置了a:a和b:b，当取值AND时，表示规则仅对同时绑定了a:a和b:b的资源生效；当取值为OR时，表示规则对任何绑定了a:a或b:b的资源生效。</value>
        [JsonConverter(typeof(EnumClassConverter<TagKeyLogicEnum>))]
        public class TagKeyLogicEnum
        {
            /// <summary>
            /// Enum AND for value: AND
            /// </summary>
            public static readonly TagKeyLogicEnum AND = new TagKeyLogicEnum("AND");

            /// <summary>
            /// Enum OR for value: OR
            /// </summary>
            public static readonly TagKeyLogicEnum OR = new TagKeyLogicEnum("OR");

            private static readonly Dictionary<string, TagKeyLogicEnum> StaticFields =
            new Dictionary<string, TagKeyLogicEnum>()
            {
                { "AND", AND },
                { "OR", OR },
            };

            private string _value;

            public TagKeyLogicEnum()
            {

            }

            public TagKeyLogicEnum(string value)
            {
                _value = value;
            }

            public static TagKeyLogicEnum FromValue(string value)
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

                if (this.Equals(obj as TagKeyLogicEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TagKeyLogicEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TagKeyLogicEnum a, TagKeyLogicEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(TagKeyLogicEnum a, TagKeyLogicEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 参数exclude_tags的取值逻辑，例如exclude_tags设置了a:a和b:b，当取值AND时，表示规则仅对同时绑定了a:a和b:b的资源生效；当取值为OR时，表示规则对任何绑定了a:a或b:b的资源生效。
        /// </summary>
        /// <value>参数exclude_tags的取值逻辑，例如exclude_tags设置了a:a和b:b，当取值AND时，表示规则仅对同时绑定了a:a和b:b的资源生效；当取值为OR时，表示规则对任何绑定了a:a或b:b的资源生效。</value>
        [JsonConverter(typeof(EnumClassConverter<ExcludeTagKeyLogicEnum>))]
        public class ExcludeTagKeyLogicEnum
        {
            /// <summary>
            /// Enum AND for value: AND
            /// </summary>
            public static readonly ExcludeTagKeyLogicEnum AND = new ExcludeTagKeyLogicEnum("AND");

            /// <summary>
            /// Enum OR for value: OR
            /// </summary>
            public static readonly ExcludeTagKeyLogicEnum OR = new ExcludeTagKeyLogicEnum("OR");

            private static readonly Dictionary<string, ExcludeTagKeyLogicEnum> StaticFields =
            new Dictionary<string, ExcludeTagKeyLogicEnum>()
            {
                { "AND", AND },
                { "OR", OR },
            };

            private string _value;

            public ExcludeTagKeyLogicEnum()
            {

            }

            public ExcludeTagKeyLogicEnum(string value)
            {
                _value = value;
            }

            public static ExcludeTagKeyLogicEnum FromValue(string value)
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

                if (this.Equals(obj as ExcludeTagKeyLogicEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ExcludeTagKeyLogicEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ExcludeTagKeyLogicEnum a, ExcludeTagKeyLogicEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ExcludeTagKeyLogicEnum a, ExcludeTagKeyLogicEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 区域ID列表
        /// </summary>
        [JsonProperty("region_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// 云服务列表
        /// </summary>
        [JsonProperty("resource_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceTypes { get; set; }

        /// <summary>
        /// 资源ID列表
        /// </summary>
        [JsonProperty("resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// 参数tags的取值逻辑，例如tags设置了a:a和b:b，当取值AND时，表示规则仅对同时绑定了a:a和b:b的资源生效；当取值为OR时，表示规则对任何绑定了a:a或b:b的资源生效。
        /// </summary>
        [JsonProperty("tag_key_logic", NullValueHandling = NullValueHandling.Ignore)]
        public TagKeyLogicEnum TagKeyLogic { get; set; }
        /// <summary>
        /// 生效标签列表
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<FilterTagDetail> Tags { get; set; }

        /// <summary>
        /// 参数exclude_tags的取值逻辑，例如exclude_tags设置了a:a和b:b，当取值AND时，表示规则仅对同时绑定了a:a和b:b的资源生效；当取值为OR时，表示规则对任何绑定了a:a或b:b的资源生效。
        /// </summary>
        [JsonProperty("exclude_tag_key_logic", NullValueHandling = NullValueHandling.Ignore)]
        public ExcludeTagKeyLogicEnum ExcludeTagKeyLogic { get; set; }
        /// <summary>
        /// 排除标签列表，排除标签列表比生效标签列表有更高的优先级
        /// </summary>
        [JsonProperty("exclude_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<FilterTagDetail> ExcludeTags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyFilterDefinitionV2 {\n");
            sb.Append("  regionIds: ").Append(RegionIds).Append("\n");
            sb.Append("  resourceTypes: ").Append(ResourceTypes).Append("\n");
            sb.Append("  resourceIds: ").Append(ResourceIds).Append("\n");
            sb.Append("  tagKeyLogic: ").Append(TagKeyLogic).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  excludeTagKeyLogic: ").Append(ExcludeTagKeyLogic).Append("\n");
            sb.Append("  excludeTags: ").Append(ExcludeTags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyFilterDefinitionV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyFilterDefinitionV2 input)
        {
            if (input == null) return false;
            if (this.RegionIds != input.RegionIds || (this.RegionIds != null && input.RegionIds != null && !this.RegionIds.SequenceEqual(input.RegionIds))) return false;
            if (this.ResourceTypes != input.ResourceTypes || (this.ResourceTypes != null && input.ResourceTypes != null && !this.ResourceTypes.SequenceEqual(input.ResourceTypes))) return false;
            if (this.ResourceIds != input.ResourceIds || (this.ResourceIds != null && input.ResourceIds != null && !this.ResourceIds.SequenceEqual(input.ResourceIds))) return false;
            if (this.TagKeyLogic != input.TagKeyLogic) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.ExcludeTagKeyLogic != input.ExcludeTagKeyLogic) return false;
            if (this.ExcludeTags != input.ExcludeTags || (this.ExcludeTags != null && input.ExcludeTags != null && !this.ExcludeTags.SequenceEqual(input.ExcludeTags))) return false;

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
                if (this.RegionIds != null) hashCode = hashCode * 59 + this.RegionIds.GetHashCode();
                if (this.ResourceTypes != null) hashCode = hashCode * 59 + this.ResourceTypes.GetHashCode();
                if (this.ResourceIds != null) hashCode = hashCode * 59 + this.ResourceIds.GetHashCode();
                hashCode = hashCode * 59 + this.TagKeyLogic.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                hashCode = hashCode * 59 + this.ExcludeTagKeyLogic.GetHashCode();
                if (this.ExcludeTags != null) hashCode = hashCode * 59 + this.ExcludeTags.GetHashCode();
                return hashCode;
            }
        }
    }
}
