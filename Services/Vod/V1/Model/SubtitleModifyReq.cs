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
    public class SubtitleModifyReq 
    {
        /// <summary>
        /// 外挂模式，不传默认取值为0  取值如下： -0：表示添加的字幕会外挂上历史产物 -1：表示添加的字幕不会外挂上历史产物
        /// </summary>
        /// <value>外挂模式，不传默认取值为0  取值如下： -0：表示添加的字幕会外挂上历史产物 -1：表示添加的字幕不会外挂上历史产物</value>
        [JsonConverter(typeof(EnumClassConverter<RepackageModeEnum>))]
        public class RepackageModeEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly RepackageModeEnum _0 = new RepackageModeEnum("0");

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly RepackageModeEnum _1 = new RepackageModeEnum("1");

            private static readonly Dictionary<string, RepackageModeEnum> StaticFields =
            new Dictionary<string, RepackageModeEnum>()
            {
                { "0", _0 },
                { "1", _1 },
            };

            private string _value;

            public RepackageModeEnum()
            {

            }

            public RepackageModeEnum(string value)
            {
                _value = value;
            }

            public static RepackageModeEnum FromValue(string value)
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

                if (this.Equals(obj as RepackageModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RepackageModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RepackageModeEnum a, RepackageModeEnum b)
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

            public static bool operator !=(RepackageModeEnum a, RepackageModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 删除模式，不传默认取值为0  取值如下： -0：表示删除字幕会清除历史产物携带的字幕信息 -1：表示删除字幕不清除历史产物携带的字幕信息
        /// </summary>
        /// <value>删除模式，不传默认取值为0  取值如下： -0：表示删除字幕会清除历史产物携带的字幕信息 -1：表示删除字幕不清除历史产物携带的字幕信息</value>
        [JsonConverter(typeof(EnumClassConverter<DeleteModeEnum>))]
        public class DeleteModeEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly DeleteModeEnum _0 = new DeleteModeEnum("0");

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly DeleteModeEnum _1 = new DeleteModeEnum("1");

            private static readonly Dictionary<string, DeleteModeEnum> StaticFields =
            new Dictionary<string, DeleteModeEnum>()
            {
                { "0", _0 },
                { "1", _1 },
            };

            private string _value;

            public DeleteModeEnum()
            {

            }

            public DeleteModeEnum(string value)
            {
                _value = value;
            }

            public static DeleteModeEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeleteModeEnum a, DeleteModeEnum b)
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

            public static bool operator !=(DeleteModeEnum a, DeleteModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 媒资ID
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 字幕默认语言(字幕必须存在)
        /// </summary>
        [JsonProperty("default_language", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// 外挂模式，不传默认取值为0  取值如下： -0：表示添加的字幕会外挂上历史产物 -1：表示添加的字幕不会外挂上历史产物
        /// </summary>
        [JsonProperty("repackage_mode", NullValueHandling = NullValueHandling.Ignore)]
        public RepackageModeEnum RepackageMode { get; set; }
        /// <summary>
        /// 删除模式，不传默认取值为0  取值如下： -0：表示删除字幕会清除历史产物携带的字幕信息 -1：表示删除字幕不清除历史产物携带的字幕信息
        /// </summary>
        [JsonProperty("delete_mode", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteModeEnum DeleteMode { get; set; }
        /// <summary>
        /// 需新增或修改的字幕
        /// </summary>
        [JsonProperty("add_subtitles", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddSubtitle> AddSubtitles { get; set; }

        /// <summary>
        /// 需删除的字幕，language不能与add_subtitles重复
        /// </summary>
        [JsonProperty("delete_subtitles", NullValueHandling = NullValueHandling.Ignore)]
        public List<DeleteSubtitle> DeleteSubtitles { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubtitleModifyReq {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  defaultLanguage: ").Append(DefaultLanguage).Append("\n");
            sb.Append("  repackageMode: ").Append(RepackageMode).Append("\n");
            sb.Append("  deleteMode: ").Append(DeleteMode).Append("\n");
            sb.Append("  addSubtitles: ").Append(AddSubtitles).Append("\n");
            sb.Append("  deleteSubtitles: ").Append(DeleteSubtitles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubtitleModifyReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubtitleModifyReq input)
        {
            if (input == null) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.DefaultLanguage != input.DefaultLanguage || (this.DefaultLanguage != null && !this.DefaultLanguage.Equals(input.DefaultLanguage))) return false;
            if (this.RepackageMode != input.RepackageMode) return false;
            if (this.DeleteMode != input.DeleteMode) return false;
            if (this.AddSubtitles != input.AddSubtitles || (this.AddSubtitles != null && input.AddSubtitles != null && !this.AddSubtitles.SequenceEqual(input.AddSubtitles))) return false;
            if (this.DeleteSubtitles != input.DeleteSubtitles || (this.DeleteSubtitles != null && input.DeleteSubtitles != null && !this.DeleteSubtitles.SequenceEqual(input.DeleteSubtitles))) return false;

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
                if (this.DefaultLanguage != null) hashCode = hashCode * 59 + this.DefaultLanguage.GetHashCode();
                hashCode = hashCode * 59 + this.RepackageMode.GetHashCode();
                hashCode = hashCode * 59 + this.DeleteMode.GetHashCode();
                if (this.AddSubtitles != null) hashCode = hashCode * 59 + this.AddSubtitles.GetHashCode();
                if (this.DeleteSubtitles != null) hashCode = hashCode * 59 + this.DeleteSubtitles.GetHashCode();
                return hashCode;
            }
        }
    }
}
