
using Homp;
using NexVYaml;
using NexVYaml.Emitter;
using NexVYaml.Serialization;
using Stride.CommunityToolkit.Engine;
using Stride.Core;
using Stride.Core.Mathematics;
using Stride.Engine;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

var x = new T<int>();
var s = YamlSerializer.SerializeToString(x);
var d = YamlSerializer.Deserialize<T<int>>(s);
namespace Homp
{
    [DataContract]
    class T<X>
    {
        public X S;
        public bool B => typeof(X).IsArray;
    }
}