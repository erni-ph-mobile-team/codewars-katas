#!/bin/bash

KATA_NAME=$1
KATA_TEST_NAME=${KATA_NAME}.Test

if ! command -v dotnet &> /dev/null
then
    echo "`dotnet` could not be found"
    exit 1
fi

mkdir $KATA_NAME
cd $KATA_NAME
dotnet new sln --name $KATA_NAME
dotnet new classlib --name $KATA_NAME
dotnet new nunit --name $KATA_TEST_NAME
dotnet new gitignore
dotnet add ${KATA_TEST_NAME}/${KATA_TEST_NAME}.csproj reference $KATA_NAME/${KATA_NAME}.csproj
dotnet sln ${KATA_NAME}.sln add $KATA_NAME/${KATA_NAME}.csproj
dotnet sln ${KATA_NAME}.sln add ${KATA_TEST_NAME}/${KATA_TEST_NAME}.csproj

echo -e "### Source\nTODO\n\n### Description\nTODO" >> README.md