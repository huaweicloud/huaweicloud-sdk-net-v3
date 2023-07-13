using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateServerBlockDeviceOption 
    {

        /// <summary>
        /// 云硬盘随实例释放策略。 -  true：云硬盘随实例释放。  -  false：云硬盘不随实例释放。  &gt; 说明 &gt; &gt; 不支持修改包年/包月计费模式的磁盘。 &gt; 不支持修改共享盘。
        /// </summary>
        [JsonProperty("delete_on_termination", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteOnTermination { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateServerBlockDeviceOption {\n");
            sb.Append("  deleteOnTermination: ").Append(DeleteOnTermination).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateServerBlockDeviceOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateServerBlockDeviceOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeleteOnTermination == input.DeleteOnTermination ||
                    (this.DeleteOnTermination != null &&
                    this.DeleteOnTermination.Equals(input.DeleteOnTermination))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DeleteOnTermination != null)
                    hashCode = hashCode * 59 + this.DeleteOnTermination.GetHashCode();
                return hashCode;
            }
        }
    }
}
