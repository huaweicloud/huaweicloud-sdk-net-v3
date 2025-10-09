using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V5.Model
{
    /// <summary>
    /// 镜像缓存信息。
    /// </summary>
    public class ImageCacheDetail 
    {
        /// <summary>
        /// **参数解释：** 镜像缓存的状态。 **约束限制：** 不涉及 **取值范围：** - Available： 可用状态，表示当前镜像缓存正常可用。 - Unavailable：不可用，表示镜像缓存状态异常或过期，不可使用。 - Creating：创建中，表示镜像缓存正在创建中。 - Deleting：删除中，表示镜像缓存正在删除中。 - Failed：创建失败，表示镜像缓存创建失败。 **默认取值：** 不涉及
        /// </summary>
        /// <value>**参数解释：** 镜像缓存的状态。 **约束限制：** 不涉及 **取值范围：** - Available： 可用状态，表示当前镜像缓存正常可用。 - Unavailable：不可用，表示镜像缓存状态异常或过期，不可使用。 - Creating：创建中，表示镜像缓存正在创建中。 - Deleting：删除中，表示镜像缓存正在删除中。 - Failed：创建失败，表示镜像缓存创建失败。 **默认取值：** 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum AVAILABLE for value: Available
            /// </summary>
            public static readonly StatusEnum AVAILABLE = new StatusEnum("Available");

            /// <summary>
            /// Enum UNAVAILABLE for value: Unavailable
            /// </summary>
            public static readonly StatusEnum UNAVAILABLE = new StatusEnum("Unavailable");

            /// <summary>
            /// Enum CREATING for value: Creating
            /// </summary>
            public static readonly StatusEnum CREATING = new StatusEnum("Creating");

            /// <summary>
            /// Enum DELETING for value: Deleting
            /// </summary>
            public static readonly StatusEnum DELETING = new StatusEnum("Deleting");

            /// <summary>
            /// Enum FAILED for value: Failed
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("Failed");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "Available", AVAILABLE },
                { "Unavailable", UNAVAILABLE },
                { "Creating", CREATING },
                { "Deleting", DELETING },
                { "Failed", FAILED },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 镜像缓存名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 镜像缓存ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 镜像缓存创建时间戳。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 镜像缓存中的容器镜像列表。
        /// </summary>
        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Images { get; set; }

        /// <summary>
        /// 镜像缓存后端对应的存储盘大小，单位GiB。
        /// </summary>
        [JsonProperty("image_cache_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ImageCacheSize { get; set; }

        /// <summary>
        /// **参数解释：** 镜像缓存有效的天数,不设置或值为0表示永久有效。镜像缓存到达有效期后自动过期并删除。 **约束限制：** 不涉及 **取值范围：** [0-10000] **默认取值：** 0 
        /// </summary>
        [JsonProperty("retention_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("building_config", NullValueHandling = NullValueHandling.Ignore)]
        public ImageCacheBuildingConfig BuildingConfig { get; set; }

        /// <summary>
        /// **参数解释：** 镜像缓存的状态。 **约束限制：** 不涉及 **取值范围：** - Available： 可用状态，表示当前镜像缓存正常可用。 - Unavailable：不可用，表示镜像缓存状态异常或过期，不可使用。 - Creating：创建中，表示镜像缓存正在创建中。 - Deleting：删除中，表示镜像缓存正在删除中。 - Failed：创建失败，表示镜像缓存创建失败。 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 镜像缓存创建失败或异常的错误信息。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageCacheDetail {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  images: ").Append(Images).Append("\n");
            sb.Append("  imageCacheSize: ").Append(ImageCacheSize).Append("\n");
            sb.Append("  retentionDays: ").Append(RetentionDays).Append("\n");
            sb.Append("  buildingConfig: ").Append(BuildingConfig).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageCacheDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageCacheDetail input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.Images != input.Images || (this.Images != null && input.Images != null && !this.Images.SequenceEqual(input.Images))) return false;
            if (this.ImageCacheSize != input.ImageCacheSize || (this.ImageCacheSize != null && !this.ImageCacheSize.Equals(input.ImageCacheSize))) return false;
            if (this.RetentionDays != input.RetentionDays || (this.RetentionDays != null && !this.RetentionDays.Equals(input.RetentionDays))) return false;
            if (this.BuildingConfig != input.BuildingConfig || (this.BuildingConfig != null && !this.BuildingConfig.Equals(input.BuildingConfig))) return false;
            if (this.Status != input.Status) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Images != null) hashCode = hashCode * 59 + this.Images.GetHashCode();
                if (this.ImageCacheSize != null) hashCode = hashCode * 59 + this.ImageCacheSize.GetHashCode();
                if (this.RetentionDays != null) hashCode = hashCode * 59 + this.RetentionDays.GetHashCode();
                if (this.BuildingConfig != null) hashCode = hashCode * 59 + this.BuildingConfig.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
