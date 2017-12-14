#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"
#include "AssemblyU2DCSharp_MessItemStatus637536183.h"

// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// MessItem
struct  MessItem_t154769011  : public Il2CppObject
{
public:
	// System.String MessItem::messItemName
	String_t* ___messItemName_0;
	// MessItemStatus MessItem::status
	int32_t ___status_1;

public:
	inline static int32_t get_offset_of_messItemName_0() { return static_cast<int32_t>(offsetof(MessItem_t154769011, ___messItemName_0)); }
	inline String_t* get_messItemName_0() const { return ___messItemName_0; }
	inline String_t** get_address_of_messItemName_0() { return &___messItemName_0; }
	inline void set_messItemName_0(String_t* value)
	{
		___messItemName_0 = value;
		Il2CppCodeGenWriteBarrier(&___messItemName_0, value);
	}

	inline static int32_t get_offset_of_status_1() { return static_cast<int32_t>(offsetof(MessItem_t154769011, ___status_1)); }
	inline int32_t get_status_1() const { return ___status_1; }
	inline int32_t* get_address_of_status_1() { return &___status_1; }
	inline void set_status_1(int32_t value)
	{
		___status_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
