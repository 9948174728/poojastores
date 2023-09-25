FROM ubuntu:22.04
RUN apt-get update
RUN apt install git wget -y
RUN git clone https://github.com/9948174728/poojastores.git
RUN mkdir dotnet
ARG ROOT=/
RUN wget https://download.visualstudio.microsoft.com/download/pr/e89c4f00-5cbb-4810-897d-f5300165ee60/027ace0fdcfb834ae0a13469f0b1a4c8/dotnet-sdk-3.1.426-linux-x64.tar.gz
RUN mkdir -p $ROOT/dotnet && tar zxf dotnet-sdk-3.1.426-linux-x64.tar.gz -C $ROOT/dotnet
ENV DOTNET_ROOT=$ROOT/dotnet
ENV PATH=$PATH:$ROOT/dotnet
RUN wget http://archive.ubuntu.com/ubuntu/pool/main/o/openssl1.0/libssl1.0.0_1.0.2n-1ubuntu5_amd64.deb
RUN dpkg -i libssl1.0.0_1.0.2n-1ubuntu5_amd64.deb
RUN cp -r ${ROOT}/poojastores/ppojastores/trunk/PoojaStores ${ROOT}/PoojaStores
WORKDIR ${ROOT}/PoojaStores
RUN apt-get install libicu-dev -y
RUN dotnet build
EXPOSE 5000
ENTRYPOINT [ "dotnet", "run", "--urls", "http://0.0.0.0:5000" ]
                                                              
