#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// XMLManager
struct XMLManager_t3569766292;
// PlayerDatabase
struct PlayerDatabase_t3858500088;
// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// XMLManager
struct  XMLManager_t3569766292  : public MonoBehaviour_t1158329972
{
public:
	// PlayerDatabase XMLManager::playerDB
	PlayerDatabase_t3858500088 * ___playerDB_3;
	// System.String XMLManager::path
	String_t* ___path_4;

public:
	inline static int32_t get_offset_of_playerDB_3() { return static_cast<int32_t>(offsetof(XMLManager_t3569766292, ___playerDB_3)); }
	inline PlayerDatabase_t3858500088 * get_playerDB_3() const { return ___playerDB_3; }
	inline PlayerDatabase_t3858500088 ** get_address_of_playerDB_3() { return &___playerDB_3; }
	inline void set_playerDB_3(PlayerDatabase_t3858500088 * value)
	{
		___playerDB_3 = value;
		Il2CppCodeGenWriteBarrier(&___playerDB_3, value);
	}

	inline static int32_t get_offset_of_path_4() { return static_cast<int32_t>(offsetof(XMLManager_t3569766292, ___path_4)); }
	inline String_t* get_path_4() const { return ___path_4; }
	inline String_t** get_address_of_path_4() { return &___path_4; }
	inline void set_path_4(String_t* value)
	{
		___path_4 = value;
		Il2CppCodeGenWriteBarrier(&___path_4, value);
	}
};

struct XMLManager_t3569766292_StaticFields
{
public:
	// XMLManager XMLManager::ins
	XMLManager_t3569766292 * ___ins_2;

public:
	inline static int32_t get_offset_of_ins_2() { return static_cast<int32_t>(offsetof(XMLManager_t3569766292_StaticFields, ___ins_2)); }
	inline XMLManager_t3569766292 * get_ins_2() const { return ___ins_2; }
	inline XMLManager_t3569766292 ** get_address_of_ins_2() { return &___ins_2; }
	inline void set_ins_2(XMLManager_t3569766292 * value)
	{
		___ins_2 = value;
		Il2CppCodeGenWriteBarrier(&___ins_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
