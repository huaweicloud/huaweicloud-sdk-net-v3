using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateStorageModeTypeReq 
    {
        /// <summary>
        /// 降冷模式。 取值如下： - WHOLE：整个媒资粒度。 - ORIGIN：原文件粒度。 
        /// </summary>
        /// <value>降冷模式。 取值如下： - WHOLE：整个媒资粒度。 - ORIGIN：原文件粒度。 </value>
        [JsonConverter(typeof(EnumClassConverter<StorageModeTypeEnum>))]
        public class StorageModeTypeEnum
        {
            /// <summary>
            /// Enum WHOLE for value: WHOLE
            /// </summary>
            public static readonly StorageModeTypeEnum WHOLE = new StorageModeTypeEnum("WHOLE");

            /// <summary>
            /// Enum ORIGIN for value: ORIGIN
            /// </summary>
            public static readonly StorageModeTypeEnum ORIGIN = new StorageModeTypeEnum("ORIGIN");

            private static readonly Dictionary<string, StorageModeTypeEnum> StaticFields =
            new Dictionary<string, StorageModeTypeEnum>()
            {
                { "WHOLE", WHOLE },
                { "ORIGIN", ORIGIN },
            };

            private string _value;

            public StorageModeTypeEnum()
            {

            }

            public StorageModeTypeEnum(string value)
            {
                _value = value;
            }

            public static StorageModeTypeEnum FromValue(string value)
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

                if (this.Equals(obj as StorageModeTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StorageModeTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StorageModeTypeEnum a, StorageModeTypeEnum b)
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

            public static bool operator !=(StorageModeTypeEnum a, StorageModeTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 降冷模式。 取值如下： - WHOLE：整个媒资粒度。 - ORIGIN：原文件粒度。 
        /// </summary>
        [JsonProperty("storage_mode_type", NullValueHandling = NullValueHandling.Ignore)]
        public StorageModeTypeEnum StorageModeType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateStorageModeTypeReq {\n");
            sb.Append("  storageModeType: ").Append(StorageModeType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateStorageModeTypeReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateStorageModeTypeReq input)
        {
            if (input == null) return false;
            if (this.StorageModeType != input.StorageModeType) return false;

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
                hashCode = hashCode * 59 + this.StorageModeType.GetHashCode();
                return hashCode;
            }
        }
    }
}
