using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 收藏项
    /// </summary>
    public class CollectionInfo 
    {
        /// <summary>
        /// 收藏项类型。 * VOICE：音色
        /// </summary>
        /// <value>收藏项类型。 * VOICE：音色</value>
        [JsonConverter(typeof(EnumClassConverter<CollectionTypeEnum>))]
        public class CollectionTypeEnum
        {
            /// <summary>
            /// Enum VOICE for value: VOICE
            /// </summary>
            public static readonly CollectionTypeEnum VOICE = new CollectionTypeEnum("VOICE");

            private static readonly Dictionary<string, CollectionTypeEnum> StaticFields =
            new Dictionary<string, CollectionTypeEnum>()
            {
                { "VOICE", VOICE },
            };

            private string _value;

            public CollectionTypeEnum()
            {

            }

            public CollectionTypeEnum(string value)
            {
                _value = value;
            }

            public static CollectionTypeEnum FromValue(string value)
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

                if (this.Equals(obj as CollectionTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CollectionTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CollectionTypeEnum a, CollectionTypeEnum b)
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

            public static bool operator !=(CollectionTypeEnum a, CollectionTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 收藏项类型。 * VOICE：音色
        /// </summary>
        [JsonProperty("collection_type", NullValueHandling = NullValueHandling.Ignore)]
        public CollectionTypeEnum CollectionType { get; set; }
        /// <summary>
        /// 收藏的资产或者模板ID。
        /// </summary>
        [JsonProperty("collection_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CollectionIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectionInfo {\n");
            sb.Append("  collectionType: ").Append(CollectionType).Append("\n");
            sb.Append("  collectionIds: ").Append(CollectionIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CollectionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CollectionInfo input)
        {
            if (input == null) return false;
            if (this.CollectionType != input.CollectionType) return false;
            if (this.CollectionIds != input.CollectionIds || (this.CollectionIds != null && input.CollectionIds != null && !this.CollectionIds.SequenceEqual(input.CollectionIds))) return false;

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
                hashCode = hashCode * 59 + this.CollectionType.GetHashCode();
                if (this.CollectionIds != null) hashCode = hashCode * 59 + this.CollectionIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
