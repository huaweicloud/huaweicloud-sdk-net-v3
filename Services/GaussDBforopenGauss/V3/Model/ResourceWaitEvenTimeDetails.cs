using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 资源类等待事件耗时
    /// </summary>
    public class ResourceWaitEvenTimeDetails 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data_io_time", NullValueHandling = NullValueHandling.Ignore)]
        public DataIoTime DataIoTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lock_time", NullValueHandling = NullValueHandling.Ignore)]
        public LockTime LockTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lwlock_time", NullValueHandling = NullValueHandling.Ignore)]
        public LwlockTime LwlockTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceWaitEvenTimeDetails {\n");
            sb.Append("  dataIoTime: ").Append(DataIoTime).Append("\n");
            sb.Append("  lockTime: ").Append(LockTime).Append("\n");
            sb.Append("  lwlockTime: ").Append(LwlockTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceWaitEvenTimeDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceWaitEvenTimeDetails input)
        {
            if (input == null) return false;
            if (this.DataIoTime != input.DataIoTime || (this.DataIoTime != null && !this.DataIoTime.Equals(input.DataIoTime))) return false;
            if (this.LockTime != input.LockTime || (this.LockTime != null && !this.LockTime.Equals(input.LockTime))) return false;
            if (this.LwlockTime != input.LwlockTime || (this.LwlockTime != null && !this.LwlockTime.Equals(input.LwlockTime))) return false;

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
                if (this.DataIoTime != null) hashCode = hashCode * 59 + this.DataIoTime.GetHashCode();
                if (this.LockTime != null) hashCode = hashCode * 59 + this.LockTime.GetHashCode();
                if (this.LwlockTime != null) hashCode = hashCode * 59 + this.LwlockTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
