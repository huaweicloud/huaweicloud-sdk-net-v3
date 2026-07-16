using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 工作流策略。
    /// </summary>
    public class WorkflowPolicy 
    {

        /// <summary>
        /// 使用场景。
        /// </summary>
        [JsonProperty("use_scene", NullValueHandling = NullValueHandling.Ignore)]
        public string UseScene { get; set; }

        /// <summary>
        /// 场景ID。
        /// </summary>
        [JsonProperty("scene_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SceneId { get; set; }

        /// <summary>
        /// 场景。
        /// </summary>
        [JsonProperty("scenes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Scene> Scenes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowPolicy {\n");
            sb.Append("  useScene: ").Append(UseScene).Append("\n");
            sb.Append("  sceneId: ").Append(SceneId).Append("\n");
            sb.Append("  scenes: ").Append(Scenes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowPolicy input)
        {
            if (input == null) return false;
            if (this.UseScene != input.UseScene || (this.UseScene != null && !this.UseScene.Equals(input.UseScene))) return false;
            if (this.SceneId != input.SceneId || (this.SceneId != null && !this.SceneId.Equals(input.SceneId))) return false;
            if (this.Scenes != input.Scenes || (this.Scenes != null && input.Scenes != null && !this.Scenes.SequenceEqual(input.Scenes))) return false;

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
                if (this.UseScene != null) hashCode = hashCode * 59 + this.UseScene.GetHashCode();
                if (this.SceneId != null) hashCode = hashCode * 59 + this.SceneId.GetHashCode();
                if (this.Scenes != null) hashCode = hashCode * 59 + this.Scenes.GetHashCode();
                return hashCode;
            }
        }
    }
}
