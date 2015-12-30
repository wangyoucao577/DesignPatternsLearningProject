#!/bin/env python
# coding=UTF-8

import os
from ctypes import *

common_lib_c_path = r"../Debug/common_lib_c.dll"
if os.path.exists(common_lib_c_path):
    common_lib_c = cdll.LoadLibrary(common_lib_c_path)
    print(common_lib_c)
    print(common_lib_c.log_print)
    print(common_lib_c.initialize_list_t)
    common_lib_c.log_print("test")
