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
    /// 直播进度信息。
    /// </summary>
    public class LivePlayingScriptInfo 
    {

        /// <summary>
        /// 剧本名称
        /// </summary>
        [JsonProperty("script_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptName { get; set; }

        /// <summary>
        /// 数字人模型资产ID，可以从资产库中查询。
        /// </summary>
        [JsonProperty("model_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelAssetId { get; set; }

        /// <summary>
        /// 拍摄脚本列表。
        /// </summary>
        [JsonProperty("shoot_scripts", NullValueHandling = NullValueHandling.Ignore)]
        public List<LivePlayingShootScriptItem> ShootScripts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LivePlayingScriptInfo {\n");
            sb.Append("  scriptName: ").Append(ScriptName).Append("\n");
            sb.Append("  modelAssetId: ").Append(ModelAssetId).Append("\n");
            sb.Append("  shootScripts: ").Append(ShootScripts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LivePlayingScriptInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LivePlayingScriptInfo input)
        {
            if (input == null) return false;
            if (this.ScriptName != input.ScriptName || (this.ScriptName != null && !this.ScriptName.Equals(input.ScriptName))) return false;
            if (this.ModelAssetId != input.ModelAssetId || (this.ModelAssetId != null && !this.ModelAssetId.Equals(input.ModelAssetId))) return false;
            if (this.ShootScripts != input.ShootScripts || (this.ShootScripts != null && input.ShootScripts != null && !this.ShootScripts.SequenceEqual(input.ShootScripts))) return false;

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
                if (this.ScriptName != null) hashCode = hashCode * 59 + this.ScriptName.GetHashCode();
                if (this.ModelAssetId != null) hashCode = hashCode * 59 + this.ModelAssetId.GetHashCode();
                if (this.ShootScripts != null) hashCode = hashCode * 59 + this.ShootScripts.GetHashCode();
                return hashCode;
            }
        }
    }
}
