using SteelSeriesGameEngine.Enumerations;
using SteelSeriesGameEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.SampleMessageGeneration.GameEventBinding.ZonePermutationGeneration
{
    public class SupportedZonePermutationsService
    {
        public IEnumerable<DeviceZonePermutation> GetAllSupportedPermutations()
        {
            var generic = GetSupportedGenericPermutations();
            var mouse = GetSupportedMousePermutations();
            var keyboard = GetSupportedKeyboardPermutations();
            var headset = GetSupportedHeadsetPermutations();

            var combined = new List<IEnumerable<DeviceZonePermutation>>() { generic };
            return combined.SelectMany(x => x);
        }

        public IEnumerable<DeviceZonePermutation> GetSupportedGenericPermutations()
        {
            return new List<DeviceZonePermutation>
            {
                new DeviceZonePermutation(DeviceType.GenericOneZone, GenericIlluminationZone.One),
                new DeviceZonePermutation(DeviceType.GenericTwoZone, GenericIlluminationZone.One),
                new DeviceZonePermutation(DeviceType.GenericTwoZone, GenericIlluminationZone.Two),
                new DeviceZonePermutation(DeviceType.GenericThreeZone, GenericIlluminationZone.One),
                new DeviceZonePermutation(DeviceType.GenericThreeZone, GenericIlluminationZone.Two),
                new DeviceZonePermutation(DeviceType.GenericThreeZone, GenericIlluminationZone.Three),
                new DeviceZonePermutation(DeviceType.GenericFiveZone, GenericIlluminationZone.One),
                new DeviceZonePermutation(DeviceType.GenericFiveZone, GenericIlluminationZone.Two),
                new DeviceZonePermutation(DeviceType.GenericFiveZone, GenericIlluminationZone.Three),
                new DeviceZonePermutation(DeviceType.GenericFiveZone, GenericIlluminationZone.Four),
                new DeviceZonePermutation(DeviceType.GenericFiveZone, GenericIlluminationZone.Five)
            };
        }
        public IEnumerable<DeviceZonePermutation> GetSupportedMousePermutations()
        {
            return new List<DeviceZonePermutation>
            {
                new DeviceZonePermutation(DeviceType.Mouse, MouseIlluminationZone.Base),
                new DeviceZonePermutation(DeviceType.Mouse, MouseIlluminationZone.Logo),
                new DeviceZonePermutation(DeviceType.Mouse, MouseIlluminationZone.Wheel)
            };
        }
        public IEnumerable<DeviceZonePermutation> GetSupportedKeyboardPermutations()
        {
            return new List<DeviceZonePermutation>
            {
                new DeviceZonePermutation(DeviceType.Keyboard, KeyBoardIlluminationZone.MainKeyboard),
                new DeviceZonePermutation(DeviceType.Keyboard, KeyBoardIlluminationZone.FunctionKeys),
                new DeviceZonePermutation(DeviceType.Keyboard, KeyBoardIlluminationZone.Keypad),
                new DeviceZonePermutation(DeviceType.Keyboard, KeyBoardIlluminationZone.NumberKeys),
                new DeviceZonePermutation(DeviceType.Keyboard, KeyBoardIlluminationZone.MacroKeys),
            };
        }
        public IEnumerable<DeviceZonePermutation> GetSupportedHeadsetPermutations()
        {
            return new List<DeviceZonePermutation>
            {
                new DeviceZonePermutation(DeviceType.Headset, HeadsetIlluminationZone.Earcups)
            };
        }
    }
}
