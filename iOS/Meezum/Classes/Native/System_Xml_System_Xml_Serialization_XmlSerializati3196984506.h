#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// System.Array
struct Il2CppArray;
// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlSerializationReader/CollectionItemFixup
struct  CollectionItemFixup_t3196984506  : public Il2CppObject
{
public:
	// System.Array System.Xml.Serialization.XmlSerializationReader/CollectionItemFixup::list
	Il2CppArray * ___list_0;
	// System.Int32 System.Xml.Serialization.XmlSerializationReader/CollectionItemFixup::index
	int32_t ___index_1;
	// System.String System.Xml.Serialization.XmlSerializationReader/CollectionItemFixup::id
	String_t* ___id_2;

public:
	inline static int32_t get_offset_of_list_0() { return static_cast<int32_t>(offsetof(CollectionItemFixup_t3196984506, ___list_0)); }
	inline Il2CppArray * get_list_0() const { return ___list_0; }
	inline Il2CppArray ** get_address_of_list_0() { return &___list_0; }
	inline void set_list_0(Il2CppArray * value)
	{
		___list_0 = value;
		Il2CppCodeGenWriteBarrier(&___list_0, value);
	}

	inline static int32_t get_offset_of_index_1() { return static_cast<int32_t>(offsetof(CollectionItemFixup_t3196984506, ___index_1)); }
	inline int32_t get_index_1() const { return ___index_1; }
	inline int32_t* get_address_of_index_1() { return &___index_1; }
	inline void set_index_1(int32_t value)
	{
		___index_1 = value;
	}

	inline static int32_t get_offset_of_id_2() { return static_cast<int32_t>(offsetof(CollectionItemFixup_t3196984506, ___id_2)); }
	inline String_t* get_id_2() const { return ___id_2; }
	inline String_t** get_address_of_id_2() { return &___id_2; }
	inline void set_id_2(String_t* value)
	{
		___id_2 = value;
		Il2CppCodeGenWriteBarrier(&___id_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
