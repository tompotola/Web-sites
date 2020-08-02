


dotnet new \
    cloudscribe \
        -D NoDb \
        -S a \
        -C true \
        -K true \
        -I true \
        -L true


dotnet new \
    cloudscribe \
        --DataStorage NoDb \
        --SimpleContentConfig a \
        --ContactForm true \
        --KvpCustomRegistration true \
        --IdentityServer true \
        --Logging true \
    --output cvjetko-sisters.cloudscribe-nodb

cd cvjetko-sisters.cloudscribe-nodb
dotnet run --verbosity:diagnostic


 https://www.cloudscribe.com/introduction   


dotnet new piranha.razor \
    --output cvjetko-sisters.piranha-razor-sqlite
cd cvjetko-sisters.piranha-razor-sqlite/
dotnet run

dotnet new piranha.mvc \
    --output cvjetko-sisters.piranha-mvc-sqlite
cd cvjetko-sisters.piranha-mvc-sqlite/
dotnet run
