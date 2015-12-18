
#ifndef __MY_STRUCTS_H__
#define __MY_STRUCTS_H__

typedef int(*subject_update_callback)(void* param);

struct subject_t
{
	void* callback_list;

	int (*attach_observer)(subject_update_callback update);
	int (*detach_observer)(subject_update_callback update);
	int (*detach_all)();
	int (*notify)();
};

#endif // __MY_STRUCTS_H__


