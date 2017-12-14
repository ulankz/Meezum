#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "mscorlib_System_DateTime693205669.h"

// System.Collections.Generic.List`1<UnityEngine.GameObject>
struct List_1_t1125654279;
// System.Collections.Generic.List`1<MessItem>
struct List_1_t3818857439;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// MessPeriodics_v01
struct  MessPeriodics_v01_t2487196392  : public MonoBehaviour_t1158329972
{
public:
	// System.Double MessPeriodics_v01::timeOffsetInMins
	double ___timeOffsetInMins_2;
	// System.Collections.Generic.List`1<UnityEngine.GameObject> MessPeriodics_v01::messGameObjects
	List_1_t1125654279 * ___messGameObjects_3;
	// System.Collections.Generic.List`1<MessItem> MessPeriodics_v01::messItems
	List_1_t3818857439 * ___messItems_4;
	// System.DateTime MessPeriodics_v01::nextEventTime
	DateTime_t693205669  ___nextEventTime_5;
	// System.Int32 MessPeriodics_v01::index
	int32_t ___index_6;

public:
	inline static int32_t get_offset_of_timeOffsetInMins_2() { return static_cast<int32_t>(offsetof(MessPeriodics_v01_t2487196392, ___timeOffsetInMins_2)); }
	inline double get_timeOffsetInMins_2() const { return ___timeOffsetInMins_2; }
	inline double* get_address_of_timeOffsetInMins_2() { return &___timeOffsetInMins_2; }
	inline void set_timeOffsetInMins_2(double value)
	{
		___timeOffsetInMins_2 = value;
	}

	inline static int32_t get_offset_of_messGameObjects_3() { return static_cast<int32_t>(offsetof(MessPeriodics_v01_t2487196392, ___messGameObjects_3)); }
	inline List_1_t1125654279 * get_messGameObjects_3() const { return ___messGameObjects_3; }
	inline List_1_t1125654279 ** get_address_of_messGameObjects_3() { return &___messGameObjects_3; }
	inline void set_messGameObjects_3(List_1_t1125654279 * value)
	{
		___messGameObjects_3 = value;
		Il2CppCodeGenWriteBarrier(&___messGameObjects_3, value);
	}

	inline static int32_t get_offset_of_messItems_4() { return static_cast<int32_t>(offsetof(MessPeriodics_v01_t2487196392, ___messItems_4)); }
	inline List_1_t3818857439 * get_messItems_4() const { return ___messItems_4; }
	inline List_1_t3818857439 ** get_address_of_messItems_4() { return &___messItems_4; }
	inline void set_messItems_4(List_1_t3818857439 * value)
	{
		___messItems_4 = value;
		Il2CppCodeGenWriteBarrier(&___messItems_4, value);
	}

	inline static int32_t get_offset_of_nextEventTime_5() { return static_cast<int32_t>(offsetof(MessPeriodics_v01_t2487196392, ___nextEventTime_5)); }
	inline DateTime_t693205669  get_nextEventTime_5() const { return ___nextEventTime_5; }
	inline DateTime_t693205669 * get_address_of_nextEventTime_5() { return &___nextEventTime_5; }
	inline void set_nextEventTime_5(DateTime_t693205669  value)
	{
		___nextEventTime_5 = value;
	}

	inline static int32_t get_offset_of_index_6() { return static_cast<int32_t>(offsetof(MessPeriodics_v01_t2487196392, ___index_6)); }
	inline int32_t get_index_6() const { return ___index_6; }
	inline int32_t* get_address_of_index_6() { return &___index_6; }
	inline void set_index_6(int32_t value)
	{
		___index_6 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
