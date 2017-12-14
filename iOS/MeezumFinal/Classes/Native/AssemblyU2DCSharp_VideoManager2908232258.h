#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// VideoManager
struct  VideoManager_t2908232258  : public MonoBehaviour_t1158329972
{
public:
	// System.String VideoManager::movPath
	String_t* ___movPath_2;

public:
	inline static int32_t get_offset_of_movPath_2() { return static_cast<int32_t>(offsetof(VideoManager_t2908232258, ___movPath_2)); }
	inline String_t* get_movPath_2() const { return ___movPath_2; }
	inline String_t** get_address_of_movPath_2() { return &___movPath_2; }
	inline void set_movPath_2(String_t* value)
	{
		___movPath_2 = value;
		Il2CppCodeGenWriteBarrier(&___movPath_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
