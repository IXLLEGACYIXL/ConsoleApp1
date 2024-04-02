
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
NexYamlSerializerRegistry.Init();
var options = new YamlSerializerOptions()
{
    SecureMode = true
};
var s = YamlSerializer.SerializeToString(x);
var d = YamlSerializer.Deserialize<T<int>>(s);
var throws = YamlSerializer.SerializeToString<Bob>(d,options);
var throws2 = YamlSerializer.Deserialize<T<int>>(throws);
namespace Homp
{
    interface Bob
    {

    }
    [DataContract]
    class T<X> : Bob
    {
        public X S;
        public bool B => typeof(X).IsArray;
    }
}