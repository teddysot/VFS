@echo off
if not exist build mkdir build
pushd build
cmake -G "Visual Studio 15 2017" ../
popd
