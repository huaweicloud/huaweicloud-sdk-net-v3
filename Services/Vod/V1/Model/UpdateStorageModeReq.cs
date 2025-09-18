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
    public class UpdateStorageModeReq 
    {
        /// <summary>
        /// 存储模式。 取值如下： - STANDARD：标准存储。 - WARM：低频存储。 - COLD：归档存储。 
        /// </summary>
        /// <value>存储模式。 取值如下： - STANDARD：标准存储。 - WARM：低频存储。 - COLD：归档存储。 </value>
        [JsonConverter(typeof(EnumClassConverter<StorageModeEnum>))]
        public class StorageModeEnum
        {
            /// <summary>
            /// Enum STANDARD for value: STANDARD
            /// </summary>
            public static readonly StorageModeEnum STANDARD = new StorageModeEnum("STANDARD");

            /// <summary>
            /// Enum WARM for value: WARM
            /// </summary>
            public static readonly StorageModeEnum WARM = new StorageModeEnum("WARM");

            /// <summary>
            /// Enum COLD for value: COLD
            /// </summary>
            public static readonly StorageModeEnum COLD = new StorageModeEnum("COLD");

            private static readonly Dictionary<string, StorageModeEnum> StaticFields =
            new Dictionary<string, StorageModeEnum>()
            {
                { "STANDARD", STANDARD },
                { "WARM", WARM },
                { "COLD", COLD },
            };

            private string _value;

            public StorageModeEnum()
            {

            }

            public StorageModeEnum(string value)
            {
                _value = value;
            }

            public static StorageModeEnum FromValue(string value)
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

                if (this.Equals(obj as StorageModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StorageModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StorageModeEnum a, StorageModeEnum b)
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

            public static bool operator !=(StorageModeEnum a, StorageModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 归档恢复方式。 取值如下： - TEMP：临时 - FOREVER：永久 
        /// </summary>
        /// <value>归档恢复方式。 取值如下： - TEMP：临时 - FOREVER：永久 </value>
        [JsonConverter(typeof(EnumClassConverter<RestoreModeEnum>))]
        public class RestoreModeEnum
        {
            /// <summary>
            /// Enum TEMP for value: TEMP
            /// </summary>
            public static readonly RestoreModeEnum TEMP = new RestoreModeEnum("TEMP");

            /// <summary>
            /// Enum FOREVER for value: FOREVER
            /// </summary>
            public static readonly RestoreModeEnum FOREVER = new RestoreModeEnum("FOREVER");

            private static readonly Dictionary<string, RestoreModeEnum> StaticFields =
            new Dictionary<string, RestoreModeEnum>()
            {
                { "TEMP", TEMP },
                { "FOREVER", FOREVER },
            };

            private string _value;

            public RestoreModeEnum()
            {

            }

            public RestoreModeEnum(string value)
            {
                _value = value;
            }

            public static RestoreModeEnum FromValue(string value)
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

                if (this.Equals(obj as RestoreModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RestoreModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RestoreModeEnum a, RestoreModeEnum b)
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

            public static bool operator !=(RestoreModeEnum a, RestoreModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 归档恢复选项，快速恢复EXPEDITED，标准恢复STANDARD，默认快速恢复 
        /// </summary>
        /// <value>归档恢复选项，快速恢复EXPEDITED，标准恢复STANDARD，默认快速恢复 </value>
        [JsonConverter(typeof(EnumClassConverter<RestoreTierEnum>))]
        public class RestoreTierEnum
        {
            /// <summary>
            /// Enum EXPEDITED for value: EXPEDITED
            /// </summary>
            public static readonly RestoreTierEnum EXPEDITED = new RestoreTierEnum("EXPEDITED");

            /// <summary>
            /// Enum STANDARD for value: STANDARD
            /// </summary>
            public static readonly RestoreTierEnum STANDARD = new RestoreTierEnum("STANDARD");

            private static readonly Dictionary<string, RestoreTierEnum> StaticFields =
            new Dictionary<string, RestoreTierEnum>()
            {
                { "EXPEDITED", EXPEDITED },
                { "STANDARD", STANDARD },
            };

            private string _value;

            public RestoreTierEnum()
            {

            }

            public RestoreTierEnum(string value)
            {
                _value = value;
            }

            public static RestoreTierEnum FromValue(string value)
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

                if (this.Equals(obj as RestoreTierEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RestoreTierEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RestoreTierEnum a, RestoreTierEnum b)
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

            public static bool operator !=(RestoreTierEnum a, RestoreTierEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 原媒资id 
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 存储模式。 取值如下： - STANDARD：标准存储。 - WARM：低频存储。 - COLD：归档存储。 
        /// </summary>
        [JsonProperty("storage_mode", NullValueHandling = NullValueHandling.Ignore)]
        public StorageModeEnum StorageMode { get; set; }
        /// <summary>
        /// 归档恢复方式。 取值如下： - TEMP：临时 - FOREVER：永久 
        /// </summary>
        [JsonProperty("restore_mode", NullValueHandling = NullValueHandling.Ignore)]
        public RestoreModeEnum RestoreMode { get; set; }
        /// <summary>
        /// 从归档转标准存储且选择临时恢复时临时恢复时间。 
        /// </summary>
        [JsonProperty("days", NullValueHandling = NullValueHandling.Ignore)]
        public int? Days { get; set; }

        /// <summary>
        /// 归档恢复选项，快速恢复EXPEDITED，标准恢复STANDARD，默认快速恢复 
        /// </summary>
        [JsonProperty("restore_tier", NullValueHandling = NullValueHandling.Ignore)]
        public RestoreTierEnum RestoreTier { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateStorageModeReq {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  storageMode: ").Append(StorageMode).Append("\n");
            sb.Append("  restoreMode: ").Append(RestoreMode).Append("\n");
            sb.Append("  days: ").Append(Days).Append("\n");
            sb.Append("  restoreTier: ").Append(RestoreTier).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateStorageModeReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateStorageModeReq input)
        {
            if (input == null) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.StorageMode != input.StorageMode) return false;
            if (this.RestoreMode != input.RestoreMode) return false;
            if (this.Days != input.Days || (this.Days != null && !this.Days.Equals(input.Days))) return false;
            if (this.RestoreTier != input.RestoreTier) return false;

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
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                hashCode = hashCode * 59 + this.StorageMode.GetHashCode();
                hashCode = hashCode * 59 + this.RestoreMode.GetHashCode();
                if (this.Days != null) hashCode = hashCode * 59 + this.Days.GetHashCode();
                hashCode = hashCode * 59 + this.RestoreTier.GetHashCode();
                return hashCode;
            }
        }
    }
}
